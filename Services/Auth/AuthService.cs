using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text.RegularExpressions;

namespace rbl_tracker.Data
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        public AuthService(DataContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;

        }
        public async Task<ServiceResponse<string>> Login(string username, string passwowrd)
        {
            var response = new ServiceResponse<string>();
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username.ToLower().Equals(username.ToLower()));

            if (user is null || !VerifyPasswordHash(passwowrd, user.PaswordHash, user.PaswordSalt))
            {
                response.Success = false;
                response.Message = "Username or password is incorrect!";
            }
            else
            {

                response.Data = CreateToken(user);
            }
            return response;

        }

        public async Task<ServiceResponse<Guid>> Register(User user, string passwowrd)
        {
            var response = new ServiceResponse<Guid>();
            if (await UserExists(user.Username))
            {
                response.Success = false;
                response.Message = "User already exists!";
                return response;
            }

            if (ValidateEmail(user.Email))
            {
                response.Success = false;
                response.Message = "Email address is incorrect!";
                return response;
            }

            if (CheckStrength(passwowrd) < PasswordScore.Fair)
            {
                response.Success = false;
                response.Message = "Password is too weak!";
                return response;
            }

            CreatePasswordHash(passwowrd, out byte[] passwordHash, out byte[] passwordSalt);
            user.PaswordHash = passwordHash;
            user.PaswordSalt = passwordSalt;

            user.CreateTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            user.UpdateTime = user.CreateTime;

            if (await FirstUser()) user.Role = UserRole.Admin; else user.Role = UserRole.User;


            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            response.Data = user.Id;
            return response;
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _context.Users.AnyAsync(u => u.Username.ToLower() == username.ToLower()))
            {
                return true;
            }
            return false;
        }

        public async Task<bool> FirstUser()
        {
            if (! await _context.Users.AnyAsync())
            {
                return true;
            }
            return false;
        }

        private void CreatePasswordHash(string passwowrd, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(passwowrd));
            }
        }
        private bool VerifyPasswordHash(string passwowrd, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(passwowrd));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private bool ValidateEmail(string email)
        {
            var _email = email.Trim();
            
            if (_email.EndsWith(".")) return false;

            var _validated = new System.Net.Mail.MailAddress(_email);

            return _validated.Address == _email;
        }

        private string CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

            var appSettingsToken = _configuration.GetSection("AppSettings:Token").Value;
            if (appSettingsToken is null)
            {
                throw new Exception("AppSettings Token is null!");
            }

            SymmetricSecurityKey key = new SymmetricSecurityKey(System.Text.Encoding.UTF8
                .GetBytes(appSettingsToken));

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials
            };
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        private enum PasswordScore
        {
            Blank = 0,
            TooShort = 1,
            RequirementsNotMet = 2,
            VeryWeak = 3,
            Weak = 4,
            Fair = 5,
            Medium = 6,
            Strong = 7,
            VeryStrong = 8
        }

        private static PasswordScore CheckStrength(string password)
        {
            int score = 0;

            // using three requirements here:  min length and two types of characters (numbers and letters)
            bool blnMinLengthRequirementMet = false;
            bool blnRequirement1Met = false;
            bool blnRequirement2Met = false;

            // check for chars in password
            if (password.Length < 1)
                return PasswordScore.Blank;

            // if less than 6 chars, return as too short, else, plus one
            if (password.Length < 6)
            {
                return PasswordScore.TooShort;
            }
            else
            {
                score++;
                blnMinLengthRequirementMet = true;
            }

            // if 8 or more chars, plus one
            if (password.Length >= 8)
                score++;

            // if 10 or more chars, plus one
            if (password.Length >= 10)
                score++;

            // if password has a number, plus one
            if (Regex.IsMatch(password, @"[\d]", RegexOptions.ECMAScript))
            {
                score++;
                blnRequirement1Met = true;
            }

            // if password has lower case letter, plus one
            if (Regex.IsMatch(password, @"[a-z]", RegexOptions.ECMAScript))
            {
                score++;
                blnRequirement2Met = true;
            }

            // if password has upper case letter, plus one
            if (Regex.IsMatch(password, @"[A-Z]", RegexOptions.ECMAScript))
            {
                score++;
                blnRequirement2Met = true;
            }

            // if password has a special character, plus one
            if (Regex.IsMatch(password, @"[~`!@#$%\^\&\*\(\)\-_\+=\[\{\]\}\|\\;:'\""<\,>\.\?\/£]", RegexOptions.ECMAScript))
                score++;

            // if password is longer than 2 characters and has 3 repeating characters, minus one (to minimum of score of 3)
            List<char> lstPass = password.ToList();
            if (lstPass.Count >= 3)
            {
                for (int i = 2; i < lstPass.Count; i++)
                {
                    char charCurrent = lstPass[i];
                    if (charCurrent == lstPass[i - 1] && charCurrent == lstPass[i - 2] && score >= 4)
                    {
                        score++;
                    }
                }
            }

            if (!blnMinLengthRequirementMet || !blnRequirement1Met || !blnRequirement2Met)
            {
                return PasswordScore.RequirementsNotMet;
            }

            return (PasswordScore)score;
        }
    }

}
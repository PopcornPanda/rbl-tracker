using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace rbl_tracker.Data
{
    public class Auth : IAuth
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        public Auth(DataContext context, IConfiguration configuration)
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

            CreatePasswordHash(passwowrd, out byte[] passwordHash, out byte[] passwordSalt);
            user.PaswordHash = passwordHash;
            user.PaswordSalt = passwordSalt;

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

        private string CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username)
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
    }
}
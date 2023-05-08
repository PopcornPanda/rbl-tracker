using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using rbl_tracker.Dtos.Auth;
using AutoMapper;

namespace rbl_tracker.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        public AuthService(IMapper mapper, DataContext context, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _context = context;
            _mapper = mapper;

        }

        public async Task<ServiceResponse<string>> Login(string username, string passwowrd)
        {
            var response = new ServiceResponse<string>();
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username.ToLower().Equals(username.ToLower()));

            if (user is null || !Validators.VerifyPasswordHash(passwowrd, user.PaswordHash, user.PaswordSalt))
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
        public async Task<ServiceResponse<GetUserDto>> Me()
        {
            var response = new ServiceResponse<GetUserDto>();
            

                var user = await _context.Users
                    .Where(u => u.Id == GetUserId()).FirstOrDefaultAsync();
                response.Data = _mapper.Map<GetUserDto>(user);


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

            if (Validators.ValidateEmail(user.Email))
            {
                response.Success = false;
                response.Message = "Email address is incorrect!";
                return response;
            }

            if (Validators.CheckStrength(passwowrd) < Validators.PasswordScore.Fair)
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

        private Guid GetUserId() => Guid.Parse(_httpContextAccessor.HttpContext!.User
            .FindFirstValue(ClaimTypes.NameIdentifier)!);

    }

}
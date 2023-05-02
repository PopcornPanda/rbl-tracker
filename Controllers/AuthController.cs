using Microsoft.AspNetCore.Mvc;
using rbl_tracker.Dtos.Auth;

namespace rbl_tracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuth _authRepo;
        public AuthController(IAuth authRepo)
        {
            _authRepo = authRepo;
            
        }
        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<Guid>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User {Username = request.Username, Email = request.Email}, request.Password
            );

            if(!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        } 

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<Guid>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(request.Username, request.Password);

            if(!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        } 
    }
}
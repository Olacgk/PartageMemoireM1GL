using PMGateway.Models;
using PMGateway.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GatewayPartageMemoire.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly ServiceExpert.ExpertServiceClient userService = new ServiceExpert.ExpertServiceClient();
        readonly AuthService authService = new AuthService();

        [HttpPost("login")]

        public IActionResult login([FromBody] UserAuthenticationDto userForAuthenticationDto)
        {
            var user = userService.VerifyEmailAndPaswword(userForAuthenticationDto.Email);
            if (user != null)
            {
                var response = new AuthResponseDto()
                {
                    IsAuthSuccessful = true,
                    Token = authService.GenerateToken(userForAuthenticationDto.Email),
                    User = user
                };
                return Ok(response);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}

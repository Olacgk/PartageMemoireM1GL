using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PMGateway.Helpers;
using PMGateway.Models;
using AutoMapper;
using System.IdentityModel.Tokens.Jwt;

namespace PMGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<UserAuthenticationDto> _userManager;
        private readonly IMapper _mapper;
        private readonly JwtHandler _jwtHandler;
        public AccountController(UserManager<UserAuthenticationDto> userManager, IMapper mapper, JwtHandler
        jwtHandler)
        {
            _userManager = userManager;
            _mapper = mapper;
            _jwtHandler = jwtHandler;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserAuthenticationDto userAuthentication)
        {
            var user = await _userManager.FindByNameAsync(userAuthentication.Email);
            if (user == null || !await _userManager.CheckPasswordAsync(user,
            userAuthentication.Password))
                return Unauthorized(new AuthResponseDto
                {
                    ErrorMessage = "Invalid Authentication"
                });
            var signingCredentials = _jwtHandler.GetSigningCredentials();
            var claims = _jwtHandler.GetClaims(user);
            var tokenOptions = _jwtHandler.GenerateTokenOptions(signingCredentials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token });
        }
    }
}

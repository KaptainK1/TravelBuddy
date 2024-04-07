using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using TravelBuddyApi.Model;
using TravelBuddyApi.Services;

namespace TravelBuddyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly ILoginService _loginService;
        private readonly IConfiguration _configuration;

        public LoginController(ILoginService loginService, IConfiguration configuration)
        {
            _loginService = loginService;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody]LoginRequest loginRequest)
        {
            var user = await _loginService.ValidateUser(loginRequest);



            if (user != null)
            {
                var epiresAt = DateTime.UtcNow.AddMinutes(5);
                var token = GenerateToken(user, epiresAt);

                return Ok(new
                {
                    access_token = token,
                    expires_at = epiresAt
                });
            } 
            else
            {
                return BadRequest();
            }


        }

        private string GenerateToken(Principal principal, DateTime expiresAt)
        {
            var key = System.Text.Encoding.ASCII.GetBytes(_configuration.GetValue<string>("SecretKey"));

            var jwt = new JwtSecurityToken(
                claims: principal.Claims, 
                notBefore: DateTime.UtcNow,
                expires: expiresAt,
                signingCredentials:
                    new SigningCredentials(
                            new SymmetricSecurityKey(key),
                            SecurityAlgorithms.HmacSha256Signature
                        )
                );

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}

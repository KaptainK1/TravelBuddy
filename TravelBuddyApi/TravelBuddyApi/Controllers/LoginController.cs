using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelBuddyApi.Model;
using TravelBuddyApi.Services;

namespace TravelBuddyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody]LoginRequest loginRequest)
        {
            var res = await _loginService.ValidateUser(loginRequest);

            if (res)
            {
                return Ok();
            } 
            else
            {
                return BadRequest();
            }


        }
    }
}

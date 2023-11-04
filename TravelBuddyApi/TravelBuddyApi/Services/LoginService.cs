using TravelBuddyApi.Model;
using System.Security.Claims;
using TravelBuddyApi.Repository;
using TravelBuddyApi.Exceptions;
using System.Net;

namespace TravelBuddyApi.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public async Task<bool> ValidateUser(LoginRequest loginRequest)
        {
            var user = await _loginRepository.ValidateUser(loginRequest);

            if (user != null)
            {
                //var claims = new List<Claim>()
                //{
                //    new Claim(ClaimTypes.Email, user.Email),
                //    new Claim(ClaimTypes.Name, user.UserName)
                //};

                //var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                //ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                //await HttpContext
                return true;
            } else
            {
                throw new ApiException(HttpStatusCode.BadRequest, "User is not authorized");
            }
            
            
        }
    }
}

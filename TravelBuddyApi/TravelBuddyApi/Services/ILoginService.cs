using TravelBuddyApi.Model;

namespace TravelBuddyApi.Services
{
    public interface ILoginService
    {
        Task<Principal> ValidateUser(LoginRequest loginRequest);
    }
}

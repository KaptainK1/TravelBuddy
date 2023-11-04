using TravelBuddyApi.Model;

namespace TravelBuddyApi.Services
{
    public interface ILoginService
    {
        Task<bool> ValidateUser(LoginRequest loginRequest);
    }
}

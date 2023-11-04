using Microsoft.AspNetCore.Identity.Data;
using TravelBuddyApi.Model;

namespace TravelBuddyApi.Repository
{
    public interface ILoginRepository
    {
        Task<Principal> ValidateUser(Model.LoginRequest loginRequest);
    }
}

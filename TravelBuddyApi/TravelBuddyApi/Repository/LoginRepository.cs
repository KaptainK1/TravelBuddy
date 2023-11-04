using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Dapper;
using TravelBuddyApi.Model;

namespace TravelBuddyApi.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly TodoContext _dbContext;

        public LoginRepository(TodoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Principal> ValidateUser(Model.LoginRequest loginRequest)
        {
            var sql = $@"
    
                    SELECT id, username, email, password, role_type
                    FROM ""TravelBuddyDB"".principal
                    WHERE email = @email
                    AND password = ""TravelBuddyDB"".crypt(@password, password);";

            return await _dbContext.Database.GetDbConnection().QueryFirstOrDefaultAsync<Principal>(sql, param: new { email = loginRequest.Email, password = loginRequest.Password});
        }
    }
}

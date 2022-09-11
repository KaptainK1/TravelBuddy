using Microsoft.EntityFrameworkCore;
using TravelBuddyApi.Model;

namespace TravelBuddyApi.Repository
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}

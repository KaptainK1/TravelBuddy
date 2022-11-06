using Microsoft.EntityFrameworkCore;
using TravelBuddyApi.Model;

namespace TravelBuddyApi.Repository
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
    }
}

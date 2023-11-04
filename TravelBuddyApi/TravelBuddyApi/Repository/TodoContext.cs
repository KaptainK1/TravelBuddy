using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Security.Principal;
using TravelBuddyApi.Model;

namespace TravelBuddyApi.Repository
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItem { get; set; }
        public DbSet<Principal> Principal { get; set; }
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TravelBuddyDB");
            modelBuilder.HasPostgresEnum<RoleType>();
        }
    }
}

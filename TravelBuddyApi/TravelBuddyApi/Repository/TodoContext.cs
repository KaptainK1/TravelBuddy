﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Reflection.Metadata;
using System.Security.Principal;
using TravelBuddyApi.Model;
using NJsonSchema.Infrastructure;

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

            modelBuilder.Entity<Principal>();
                        //.HasMany(p => p.TodoItems)
                        //.WithOne(p => p.Principal)
                        //.HasForeignKey(e => e.PrincipalId);
            modelBuilder.Entity<TodoItem>()
                        .HasOne(t => t.Principal);
                        //.WithMany(t => t.TodoItems)
                        //.HasForeignKey(t => t.PrincipalId);
        }
    }
}

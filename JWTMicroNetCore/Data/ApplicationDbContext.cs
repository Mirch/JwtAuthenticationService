using JWTMicroNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTMicroNetCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<User>()
                .HasData(
                new User { Id = 1, Username = "User1", Password = "Password1" },
                new User { Id = 2, Username = "User2", Password = "Password2" }
                );
        }
    }
}

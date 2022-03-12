using System.Collections.Generic;
using FirstWeb.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstWeb.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                    Id = "111adw43-k321-542a-aaaf-4g9f03vv0402",
                    Name = "admin",
                    NormalizedName = "ADMIN"
                });

                modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
                {
                    Id = "222adguu-2g21-h42a-a5af-11111vv35555",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@email.com",
                    NormalizedEmail = "MY@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "adminpassword"),
                    SecurityStamp = string.Empty
                });

                modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                    RoleId = "111adw43-k321-542a-aaaf-4g9f03vv0402",
                    UserId = "222adguu-2g21-h42a-a5af-11111vv35555"
                });
        }
    }
}
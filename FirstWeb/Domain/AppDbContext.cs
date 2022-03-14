using System;
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
                    Id = "111AAA43-A321-542A-AAAF-4F9F03FF0402",
                    Name = "admin",
                    NormalizedName = "ADMIN"
                });

                modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
                {
                    Id = "222AAAAA-2A21-F42A-F5AF-11111FF35555",
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
                    RoleId = "111DDD43-F321-542a-AFFF-4A9F03FF0402",
                    UserId = "222DDDDD-2A21-A42C-C5AA-11111AA35555"
                });

                modelBuilder.Entity<TextField>().HasData(new TextField
                {
                    Id = new Guid("11111111-1151-DDC2-A3AF-2DD93DDDD023"),
                    CodeWord = "PageIndex",
                    Title = "Главная"
                });
                
                modelBuilder.Entity<TextField>().HasData(new TextField
                {
                    Id = new Guid("22222222-1151-DDC2-A3AF-2DD93DDDD023"),
                    CodeWord = "PageServices",
                    Title = "Услуги"
                });
                
                modelBuilder.Entity<TextField>().HasData(new TextField
                {
                    Id = new Guid("33333333-1151-DDC2-A3AF-2DD93DDDD023"),
                    CodeWord = "PageContacts",
                    Title = "Контакты"
                });
                
                
        }
    }
}
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedIdentity();
            return modelBuilder;
        }
        private static void SeedIdentity(this ModelBuilder modelBuilder)
        {
            var adminRole = new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" };
            var customerRole = new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" };
            var businessRole = new IdentityRole { Name = "Business", NormalizedName = "BUSINESS" };

            modelBuilder.Entity<IdentityRole>().HasData(
                adminRole,
                customerRole,
                businessRole
            );

            var passwordHasher = new PasswordHasher<IdentityUser>();
            string defaultPassword = "Password123";

            var adminUser = new IdentityUser { Email = "carter@admin.com", UserName = "carter@admin.com", NormalizedEmail = "CARTER@ADMIN.COM", NormalizedUserName = "CARTER@ADMIN.COM" };
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, defaultPassword);
            var customerUser = new IdentityUser { Email = "carter@customer.com", UserName = "carter@customer.com", NormalizedEmail = "CARTER@CUSTOMER.COM", NormalizedUserName = "CARTER@CUSTOMER.COM" };
            customerUser.PasswordHash = passwordHasher.HashPassword(customerUser, defaultPassword);
            var businessUser = new IdentityUser { Email = "carter@business.com", UserName = "carter@business.com", NormalizedEmail = "CARTER@BUSINESS.COM", NormalizedUserName = "CARTER@BUSINESS.COM" };
            businessUser.PasswordHash = passwordHasher.HashPassword(businessUser, defaultPassword);

            modelBuilder.Entity<IdentityUser>().HasData(
                adminUser,
                customerUser,
                businessUser
            );

            var adminUserRole = new IdentityUserRole<string> { RoleId = adminRole.Id, UserId = adminUser.Id };
            var businessUserRole = new IdentityUserRole<string> { RoleId = businessRole.Id, UserId = businessUser.Id };
            var customerUserRole = new IdentityUserRole<string> { RoleId = customerRole.Id, UserId = adminUser.Id };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                adminUserRole,
                customerUserRole,
                businessUserRole
            );
        }
    }
}

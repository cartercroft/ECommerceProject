using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Helpers
{
    public static class UserRoleHelpers
    {
        public static async Task CreateRolesAsync(IServiceProvider serviceProvider, IConfiguration config)
        {
            string[] roles = (string[])config.GetValue(typeof(string[]), "DefaultRoles");

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole { Name = role });
                }
            }
        }

        //struct UserDetails
        //{
        //    string Username;
        //    string Password;
        //};
        //public static async Task CreateUsersAsync(IServiceProvider serviceProvider, IConfiguration config)
        //{
        //    var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

        //    if (userManager.Users.Where(u => u.Email == ).FirstOrDefault() == null)
        //    {
        //        var user = new IdentityUser
        //        {
        //            Email = "admin@examplecompany.com",
        //            UserName = "admin@examplecompany.com",
        //        };

        //        await userManager.CreateAsync(user, "Admin@12345");
        //        await userManager.AddToRoleAsync(user, "SystemAdministrator");
        //    }
        //}
    }
}

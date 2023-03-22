using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Extensions
{
    public static class UserManagerExtensions
    {
        public static async Task AddDefaultRoles(this UserManager<IdentityUser> userManager, IdentityUser user)
        {
            await userManager.AddToRoleAsync(user, "CUSTOMER");
        }
    }
}

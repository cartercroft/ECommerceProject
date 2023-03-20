using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Services.Roles
{
    public interface IRoleService : IDataService<IdentityRole, string>
    {
        public Task<List<IdentityUserRole<string>?>?> GetRolesForUser(IdentityUser user);
    }
}

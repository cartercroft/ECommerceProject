using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Services.Roles
{
    public interface IRoleService : IDataService<IdentityRole, string>
    {
        public Task<List<IdentityRole>> GetRolesForUserAsync(IdentityUser user);
        public List<IdentityRole> GetRolesForUser(IdentityUser user);
    }
}

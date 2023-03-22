using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Data.Repositories.Roles
{
    public interface IRoleRepository : IDataRepository<IdentityRole, string>
    {
        Task<List<IdentityRole>> GetRolesForUserAsync(IdentityUser user);
        List<IdentityRole> GetRolesForUser(IdentityUser user);
    }
}

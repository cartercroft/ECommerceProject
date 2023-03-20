using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Data.Repositories.Roles
{
    public interface IRoleRepository : IDataRepository<IdentityRole, string>
    {
        Task<IEnumerable<IdentityUserRole<string>?>?> GetRolesForUser(IdentityUser user);
    }
}

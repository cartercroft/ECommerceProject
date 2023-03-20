using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Data.Repositories.Users
{
    public interface IUserRepository : IDataRepository<IdentityUser, string>
    {
        Task AddUserToRole(IdentityUser user, IdentityRole role);
    }
}

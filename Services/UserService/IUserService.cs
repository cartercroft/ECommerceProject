using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Services.UserService
{
    public interface IUserService
    {
        Task<IdentityUser> Get(string id);
        Task<IEnumerable<IdentityUser?>?> GetAll();
        Task<IdentityUser> Add(IdentityUser model);
        Task<IdentityUser> Update(IdentityUser model);
        Task<bool> Delete(string id);
    }
}

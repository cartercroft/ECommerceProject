using ECommerceProject.Data.Repositories.Roles;
using ECommerceProject.Data.Repositories.Users;
using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Data
{
    public interface IRepositoryManager
    {
        public IRoleRepository Roles { get; set; }
        public IUserRepository Users { get; set; }
        Task<bool> SaveChangesAsync();
        bool SaveChanges();
    }
}

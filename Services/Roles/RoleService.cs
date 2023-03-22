using ECommerceProject.Data;
using ECommerceProject.Data.Repositories.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore;

namespace ECommerceProject.Services.Roles
{
    public class RoleService : IRoleService
    {
        private readonly IRepositoryManager _repositoryManager;
        public RoleService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<IdentityRole?> Get(string id)
        {
            return await _repositoryManager.Roles.Get(id);
        }
        public async Task<List<IdentityRole?>?> GetAll()
        {
            return await _repositoryManager.Roles.GetAll();
        }
        public async Task<IdentityRole?> Update(IdentityRole role)
        {
            var result = await _repositoryManager.Roles.Update(role);
            await _repositoryManager.SaveChangesAsync();
            return result;
        }
        public async Task<IdentityRole?> Add(IdentityRole? role)
        {
            if(role != null)
            {
                var savedRole = await _repositoryManager.Roles.Add(role);
                await _repositoryManager.SaveChangesAsync();
                return await Get(savedRole.Id);
            }
            return null;
        }
        public async Task<bool> Delete(string id)
        {
            var result = await _repositoryManager.Roles.Delete(id);
            await _repositoryManager.SaveChangesAsync();
            return result;
        }
        public List<IdentityRole> GetRolesForUser(IdentityUser user)
        {
            return _repositoryManager.Roles.GetRolesForUser(user);
        }
        public async Task<List<IdentityRole>> GetRolesForUserAsync(IdentityUser user)
        {
            return await _repositoryManager.Roles.GetRolesForUserAsync(user);
        }
    }
}

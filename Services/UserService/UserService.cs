using ECommerceProject.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ECommerceProject.Services.UserService
{
    public class UserService : IUserService
    {
        private IRepositoryManager _repositoryManager;
        private readonly UserManager<IdentityUser> _userManager;
        public UserService(IRepositoryManager repositoryManager, UserManager<IdentityUser> userManager)
        {
            _repositoryManager = repositoryManager;
            _userManager = userManager;
        }
        public async Task<IdentityUser?> Add(IdentityUser model)
        {
            if(model != null)
            {
                var savedUser = await _repositoryManager.Users.Add(model);
                await _repositoryManager.SaveChangesAsync();
                return await Get(savedUser.Id);
            }
            return null;
        }

        public async Task AddUserToRole(IdentityUser user, IdentityRole role)
        {
            if(user != null && role != null)
            {
                await _userManager.AddToRoleAsync(user, role.Name);
                await _repositoryManager.SaveChangesAsync();
            }
        }

        public async Task<bool> Delete(string id)
        {
            var res = await _userManager.DeleteAsync(await _userManager.FindByIdAsync(id));
            await _repositoryManager.SaveChangesAsync();
            return res.Succeeded;   
        }

        public async Task<IdentityUser> Get(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public Task<IEnumerable<IdentityUser?>?> GetAll()
        {
            return _repositoryManager.Users.GetAll();
        }

        public async Task<IdentityUser?> Update(IdentityUser model)
        {
            await _userManager.UpdateAsync(model);
            await _repositoryManager.SaveChangesAsync();
            return await _repositoryManager.Users.Get(model.Id);
        }
    }
}

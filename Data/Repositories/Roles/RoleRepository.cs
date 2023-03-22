using ECommerceProject.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Data.Repositories.Roles
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;
        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IdentityRole?> Get(string id)
        {
            return await _context.Roles.FindAsync(id);
        }
        public async Task<List<IdentityRole>> GetAll()
        {
            return await _context.Roles.ToListAsync();
        }
        public async Task<IdentityRole?> Add(IdentityRole role)
        {
            var result = await _context.Roles.AddAsync(role);
            return result?.Entity;
        }
        public async Task<IdentityRole?> Update(IdentityRole role)
        {
            var result = _context.Roles.Update(role);
            return result?.Entity;
        }
        public async Task<bool> Delete(string id)
        {
            var result = _context.Remove(await Get(id));
            return result?.Entity != null;
        }

        public async Task<List<IdentityRole>> GetRolesForUserAsync(IdentityUser user)
        {
            return await (from userRole in _context.UserRoles
                          where userRole.UserId == user.Id
                         join role in _context.Roles on userRole.RoleId equals role.Id
                         select role).ToListAsync();
        }
        public List<IdentityRole> GetRolesForUser(IdentityUser user)
        {
            return (from userRole in _context.UserRoles
                    where userRole.UserId == user.Id
                   join role in _context.Roles on userRole.RoleId equals role.Id
                   select role).ToList();
        }
    }
}

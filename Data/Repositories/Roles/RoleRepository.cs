﻿using ECommerceProject.Data.Repositories;
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
        public async Task<IEnumerable<IdentityRole?>?> GetAll()
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

        public async Task<IEnumerable<IdentityUserRole<string>?>?> GetRolesForUser(IdentityUser user)
        {
            return await _context.UserRoles.Where(x => x.UserId == user.Id).ToListAsync();
        }
    }
}

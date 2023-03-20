﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Data.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IdentityUser?> Add(IdentityUser model)
        {
            var result = await _context.AddAsync(model);
            return result?.Entity;
        }

        public async Task AddUserToRole(IdentityUser user, IdentityRole role)
        {
            IdentityUserRole<string> userRole = new IdentityUserRole<string>();
            userRole.RoleId = role.Id;
            userRole.UserId = user.Id;
            await _context.UserRoles.AddAsync(userRole);
        }

        public async Task<bool> Delete(string id)
        {
            var result = _context.Users.Remove(await Get(id));
            return result?.Entity != null;
        }

        public async Task<IdentityUser?> Get(string id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<IdentityUser?>?> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<IdentityUser?> Update(IdentityUser model)
        {
            var result = _context.Users.Update(model);
            return result?.Entity;
        }
    }
}

using ECommerceProject.Data.Repositories;
using ECommerceProject.Data.Repositories.Roles;
using ECommerceProject.Data.Repositories.Users;
using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Data
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationDbContext _context;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;
        public RepositoryManager(ApplicationDbContext context)
        {
            _context = context;
        }
        public IRoleRepository Roles 
        { 
            get
            {
                return _roleRepository ?? new RoleRepository(_context);
            }
            set
            {
                value = _roleRepository;
            }
        }
        public IUserRepository Users
        {
            get
            {
                return _userRepository ?? new UserRepository(_context);
            }
            set
            {
                value = _userRepository;
            }
        }
        public bool SaveChanges()
        {
            return _context.SaveChanges() == 1;
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) == 1;
        }
    }
}

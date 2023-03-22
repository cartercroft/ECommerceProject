using ECommerceProject.Data.Repositories;
using ECommerceProject.Data.Repositories.Roles;
using ECommerceProject.Data.Repositories.Users;
using ECommerceProject.Data.Repositories.ProductCategories;
using ECommerceProject.Data.Repositories.Products;
using ECommerceProject.Data.Repositories.Businesses;
using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Data
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationDbContext _context;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IProductRepository _productRepository;
        private readonly IBusinessRepository _businessRepository;
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
        public IBusinessRepository Businesses
        {
            get
            {
                return _businessRepository ?? new BusinessRepository(_context);
            }
            set
            {
                value = _businessRepository;
            }
        }
        public IProductCategoryRepository ProductCategories
        {
            get
            {
                return _productCategoryRepository ?? new ProductCategoryRepository(_context);
            }
            set
            {
                value = _productCategoryRepository;
            }
        }
        public IProductRepository Products
        {
            get
            {
                return _productRepository ?? new ProductRepository(_context);
            }
            set
            {
                value = _productRepository;
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

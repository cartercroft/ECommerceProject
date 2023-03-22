using ECommerceProject.Data.Repositories.Roles;
using ECommerceProject.Data.Repositories.Users;
using ECommerceProject.Data.Repositories.Products;
using ECommerceProject.Data.Repositories.ProductCategories;
using ECommerceProject.Data.Repositories.Businesses;
using Microsoft.AspNetCore.Identity;

namespace ECommerceProject.Data
{
    public interface IRepositoryManager
    {
        public IRoleRepository Roles { get; set; }
        public IUserRepository Users { get; set; }
        public IProductCategoryRepository ProductCategories { get; set; }
        public IProductRepository Products { get; set; }
        public IBusinessRepository Businesses { get; set; }
        Task<bool> SaveChangesAsync();
        bool SaveChanges();
    }
}

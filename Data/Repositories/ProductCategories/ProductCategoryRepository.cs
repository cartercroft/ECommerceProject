using ECommerceProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Data.Repositories.ProductCategories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private ApplicationDbContext _context;
        public ProductCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ProductCategory?> Add(ProductCategory model)
        {
            var result = await _context.ProductCategories.AddAsync(model);
            return result.Entity;
        }

        public async Task<bool> Delete(int id)
        {
            var result = _context.ProductCategories.Remove(await Get(id));
            return result.Entity != null;
        }

        public async Task<ProductCategory?> Get(int id)
        {
            return await _context.ProductCategories
                .Include(x => x.Products)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ProductCategory>> GetAll()
        {
            return await _context.ProductCategories
                .Include(x => x.Products)
                .ToListAsync();
        }

        public async Task<ProductCategory?> Update(ProductCategory model)
        {
            var result = _context.ProductCategories.Update(model);
            return result.Entity;
        }
    }
}

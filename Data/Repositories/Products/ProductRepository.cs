using ECommerceProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Data.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Product?> Add(Product model)
        {
            var result = await _context.Products.AddAsync(model);
            return result.Entity;
        }

        public async Task<bool> Delete(int id)
        {
            var result = _context.Products.Remove(await Get(id));
            return result.Entity != null;
        }

        public async Task<Product?> Get(int id)
        {
            return await _context.Products
                .Include(x => x.Categories)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products
                .Include(x => x.Categories)
                .ToListAsync();
        }

        public async Task<Product?> Update(Product model)
        {
            var result = _context.Products.Update(model);
            return result.Entity;
        }
    }
}

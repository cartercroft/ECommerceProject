using ECommerceProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Data.Repositories.Businesses
{
    public class BusinessRepository : IBusinessRepository
    {
        private ApplicationDbContext _context;
        public BusinessRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Business?> Add(Business model)
        {
            var result = await _context.Businesses.AddAsync(model);
            return result.Entity;
        }

        public async Task<bool> Delete(int id)
        {
            var result = _context.Businesses.Remove(await Get(id));
            return result.Entity != null;
        }

        public async Task<Business?> Get(int id)
        {
            return await _context.Businesses
                .Include(x => x.Products)
                .Include(x => x.Owner)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Business>> GetAll()
        {
            return await _context.Businesses
                .Include(x => x.Products)
                .Include(x => x.Owner)
                .ToListAsync();
        }

        public async Task<Business?> Update(Business model)
        {
            var result = _context.Businesses.Update(model);
            return result.Entity;
        }
    }
}

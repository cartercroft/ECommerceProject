using ECommerceProject.Data;
using ECommerceProject.Models;
using ECommerceProject.Services.Images;

namespace ECommerceProject.Services.Products
{
    public class ProductService : IProductService
    {
        private IRepositoryManager _repositoryManager;
        public ProductService(IRepositoryManager repositoryManager, IImageUploadService imageUploadService)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<Product?> Add(Product model)
        {
            var result = await _repositoryManager.Products.Add(model);
            await _repositoryManager.SaveChangesAsync();
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _repositoryManager.Products.Delete(id);
            await _repositoryManager.SaveChangesAsync();
            return result;
        }

        public async Task<Product?> Get(int id)
        {
            Product result = await _repositoryManager.Products.Get(id);
            return result;
        }

        public async Task<List<Product?>?> GetAll()
        {
            return await _repositoryManager.Products.GetAll();
        }

        public async Task<Product?> Update(Product model)
        {
            var result = await _repositoryManager.Products.Update(model);
            await _repositoryManager.SaveChangesAsync();
            return result;
        }
    }
}

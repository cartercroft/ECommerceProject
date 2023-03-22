using ECommerceProject.Data;
using ECommerceProject.Models;

namespace ECommerceProject.Services.ProductCategories
{
    public class ProductCategoryService : IProductCategoryService
    {
        private IRepositoryManager _repositoryManager;
        public ProductCategoryService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<ProductCategory?> Add(ProductCategory model)
        {
            var result = await _repositoryManager.ProductCategories.Add(model);
            await _repositoryManager.SaveChangesAsync();
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _repositoryManager.ProductCategories.Delete(id);
            await _repositoryManager.SaveChangesAsync();
            return result;
        }

        public async Task<ProductCategory?> Get(int id)
        {
            return await _repositoryManager.ProductCategories.Get(id);
        }

        public async Task<List<ProductCategory?>?> GetAll()
        {
            return await _repositoryManager.ProductCategories.GetAll();
        }

        public async Task<ProductCategory?> Update(ProductCategory model)
        {
            var result = await _repositoryManager.ProductCategories.Update(model);
            await _repositoryManager.SaveChangesAsync();
            return result;
        }
    }
}

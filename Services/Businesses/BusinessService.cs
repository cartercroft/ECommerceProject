using ECommerceProject.Data;
using ECommerceProject.Models;

namespace ECommerceProject.Services.Businesses
{
    public class BusinessService : IBusinessService
    {
        private IRepositoryManager _repositoryManager;
        public BusinessService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<Business?> Add(Business model)
        {
            var result = await _repositoryManager.Businesses.Add(model);
            await _repositoryManager.SaveChangesAsync();
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _repositoryManager.Businesses.Delete(id);
            await _repositoryManager.SaveChangesAsync();
            return result;
        }

        public async Task<Business?> Get(int id)
        {
            return await _repositoryManager.Businesses.Get(id);
        }

        public async Task<List<Business?>?> GetAll()
        {
            return await _repositoryManager.Businesses.GetAll();
        }

        public async Task<Business?> Update(Business model)
        {
            var result = await _repositoryManager.Businesses.Update(model);
            await _repositoryManager.SaveChangesAsync();
            return result;
        }
    }
}

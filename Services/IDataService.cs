﻿namespace ECommerceProject.Services
{
    public interface IDataService<TModel, TKey> 
    {
        Task<TModel?> Get(TKey id);
        Task<List<TModel?>?> GetAll();
        Task<TModel?> Add(TModel model);
        Task<TModel?> Update(TModel model);
        Task<bool> Delete(TKey id);
    }
}

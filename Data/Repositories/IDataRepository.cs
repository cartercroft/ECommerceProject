namespace ECommerceProject.Data.Repositories
{
    public interface IDataRepository<TModel, TKey>
    {
        public Task<TModel?> Get(TKey id);
        public Task<IEnumerable<TModel?>?> GetAll();
        public Task<TModel?> Add(TModel model);
        public Task<bool> Delete(TKey id);
        public Task<TModel?> Update(TModel model);
        //TODO: Maybe implement? Want to find a way to only update properties passed in as not null
        //public Task<TModel?> Patch(TModel model);
    }
}

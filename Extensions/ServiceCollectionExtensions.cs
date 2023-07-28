using ECommerceProject.Data.Repositories.Roles;
using ECommerceProject.Data.Repositories.Users;
using ECommerceProject.Data.Repositories.Businesses;
using ECommerceProject.Data.Repositories.Products;
using ECommerceProject.Data.Repositories.ProductCategories;
using ECommerceProject.Services.ShoppingCart;

namespace ECommerceProject.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataServices(this IServiceCollection services)
        {
            services.Scan(x =>
            {
                x.FromCallingAssembly().AddClasses().AsMatchingInterface();
            });
            services.AddScoped<IShoppingCartService, ShoppingCartService>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddTransient<IBusinessRepository, BusinessRepository>();
            return services;
        }
    }
}

using ECommerceProject.Data.Repositories.Roles;
using ECommerceProject.Data.Repositories.Users;

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

            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }
    }
}

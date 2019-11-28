using FishAquariumWebApp.Services;
using FishAquariumWebApp.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FishAquariumWebApp.Configurations
{
    public static class DependencyConfigurations
    {
        public static IServiceCollection AddAllDependencies(this IServiceCollection services)
        {
            return services
                .AddRepositoryDependencies()
                .AddServiceDependencies();
        }
        
        public static IServiceCollection AddRepositoryDependencies(this IServiceCollection services)
        {
            return services
                /*.AddScoped<IUsersRepository, UsersRepository>()*/;
        }
        
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            return services/*.AddSingleton<ITimeService, TimeService>()*/
                .AddSingleton<IRoleService, RoleService>();
        }
    }
}

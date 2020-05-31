using Data.Repositories;
using Data.Repositories.Contracts;
using Facade.Contracts;
using Facades;
using Microsoft.Extensions.DependencyInjection;

namespace REST_API.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            #region Domain
            services.AddScoped<IDuckFacade, DuckFacade>();
            #endregion

            #region Data
            services.AddScoped<IDuckRepository, DuckRepository>();
            #endregion
        }
    }
}

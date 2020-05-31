using Data.Repositories;
using Data.Repositories.Contexts;
using Data.Repositories.Contracts;
using Facade.Contracts;
using Facades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace REST_API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["sqlServerConnection:connectionString"];
            services.AddDbContext<MainContext>(o => o.UseSqlServer(connectionString));
        }       
    }
}

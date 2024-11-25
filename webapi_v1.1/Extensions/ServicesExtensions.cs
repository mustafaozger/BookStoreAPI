using System.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Repositories.Contracts;
using Repositories.EFCore;
using Services;
using Services.Contracts;

namespace webapi_v1.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigurationSqlService(this IServiceCollection services,
            IConfiguration configuration)=> services.AddDbContext<RepositoryContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
    
        public static void ConfigureRepositoryManage(this IServiceCollection services)
            =>services.AddScoped<IRepositoryManager,RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services)
            =>services.AddScoped<IServiceManager,ServiceManager>();
    }
}
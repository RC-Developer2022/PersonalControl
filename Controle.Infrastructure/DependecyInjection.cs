using Controle.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Controle.Infrastructure;

public static class DependecyInjection 
{
    public static IServiceCollection AddDbConfigEntityFrameworkCore(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ControleContext>(x =>
            x.UseSqlServer(configuration.GetConnectionString("SqlServerDb")));

        services.AddSingleton<DapperContext>();
        
        return services;
    }
}

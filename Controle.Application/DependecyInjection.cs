using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Controle.Infrastructure;

namespace Controle.Application;

public static class DependecyInjection
{
    public static IServiceCollection AddServicesApplication(this IServiceCollection services, IConfiguration configuration) 
    {
        services.AddDbConfigEntityFrameworkCore(configuration);

        return services;
    }
}

using Peak.Application.Services;
using Peak.Domain.Interfaces.Repositories;
using Peak.Domain.Interfaces.Services;
using Peak.Infrastructure.Repositories;

namespace Peak.API.Configurations;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection AddDepedencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICalculateService, CalculateService>();
        services.AddScoped<IConsultService, ConsultService>();
        services.AddScoped<IConsultRepository, ConsultRepository>();

        return services;
    }
}
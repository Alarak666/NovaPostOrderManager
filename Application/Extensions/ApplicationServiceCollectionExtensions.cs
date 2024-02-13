using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddBusinessLogicApplicationServices(this IServiceCollection services)
    {
        return services;
    }
}
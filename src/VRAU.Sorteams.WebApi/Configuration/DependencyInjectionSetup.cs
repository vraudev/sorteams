using VRAU.Sorteams.Domain.Context;

namespace VRAU.Sorteams.WebApi.Configuration;

public static class DependencyInjectionSetup
{
    public static void AddDependencyInjectionSetup(this IServiceCollection services)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));

        services.AddScoped<SorteamsContext>();
    }
}

using Microsoft.EntityFrameworkCore;
using VRAU.Sorteams.Domain.Context;

namespace VRAU.Sorteams.WebApi.Configuration;

public static class DatabaseSetup
{
    public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));

        var serverVersion = new MySqlServerVersion(new Version(8, 0, 36));

        services.AddDbContext<SorteamsContext>(options =>
            options.UseMySql(configuration.GetConnectionString("DefaultConnection"), serverVersion));
    }
}

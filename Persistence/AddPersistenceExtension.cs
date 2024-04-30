using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence;

public static class AddPersistenceExtension
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        => services.AddDbContext<IDbContext, DbContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("PostgresConnection")));
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpaceReserve.Infrastructure.Contracts;
using SpaceReserve.Infrastructure.Data;
using SpaceReserve.Infrastructure.Repositories;

namespace SpaceReserve.Infrastructure.Extensions;

public static class InfrastructureExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("DatabaseString"))
        );
        services.AddScoped<IUsersRepository, UserRepository>();
        services.AddScoped<IWorkspaceRepository, WorkspaceRepository>();
    }
}

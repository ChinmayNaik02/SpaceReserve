using System.Reflection;
using FluentValidation.AspNetCore;
using SpaceReserve.AppService.Configurations;
using SpaceReserve.AppService.Extensions;
using SpaceReserve.Infrastructure.Extensions;

namespace SpaceReserve.API.Extensions;

public static class Startup
{
    [Obsolete]
    public static void AddStartupServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddAutoMapper(typeof(AutoMapperConfigurations));
        builder.Services.AddControllers();
                        // .AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(Assembly.Load("AppointmentBookingSystem.AppService")));
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddAppServices();
        builder.Services.AddInfrastructure(builder.Configuration);
    }
}

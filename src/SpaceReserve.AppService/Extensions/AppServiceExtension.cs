using Microsoft.Extensions.DependencyInjection;
using SpaceReserve.AppService.Contracts;
using SpaceReserve.AppService.Services;

namespace SpaceReserve.AppService.Extensions;

public static class AppServiceExtension
{
     public static void AddAppServices(this IServiceCollection services)
     {
          services.AddTransient<IUserService, UserService>();
          services.AddTransient<IWorkspaceService, WorkspaceService>();
          services.AddTransient<IBookingService, BookingServiceImplement>();
     }
}

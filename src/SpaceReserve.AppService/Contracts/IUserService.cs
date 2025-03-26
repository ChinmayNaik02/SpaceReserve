using SpaceReserve.AppService.DTOs;
using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.AppService.Contracts;

public interface IUserService
{
    Task<GetUserDto?> GetByIdAsync(int id);
}

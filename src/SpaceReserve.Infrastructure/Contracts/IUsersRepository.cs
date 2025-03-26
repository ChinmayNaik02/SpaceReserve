using SpaceReserve.Infrastructure.Data;
using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.Infrastructure.Contracts;

public interface IUsersRepository
{
    Task<User?> GetUserByIdAsync(int id);
}

using Microsoft.EntityFrameworkCore;
using SpaceReserve.Infrastructure.Contracts;
using SpaceReserve.Infrastructure.Data;
using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.Infrastructure.Repositories;

public class UserRepository : IUsersRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetUserByIdAsync(int id)
    {
        User? user = await _context.Users.FirstOrDefaultAsync(u => u.UserID == id);
        return user;
    }
}
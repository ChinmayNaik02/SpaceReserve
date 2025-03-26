using AutoMapper;
using SpaceReserve.AppService.Contracts;
using SpaceReserve.AppService.DTOs;
using SpaceReserve.Infrastructure.Contracts;
using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.AppService.Services;

public class UserService : IUserService
{
    private readonly IUsersRepository _usersRepository;
    private readonly IMapper _mapper;

    public UserService(IUsersRepository usersRepository, IMapper mapper)
    {
        _usersRepository = usersRepository;
        _mapper = mapper;
    }

    public async Task<GetUserDto?> GetByIdAsync(int id)
    {
        var user = await _usersRepository.GetUserByIdAsync(id);

        if (user == null)
        {
            throw new KeyNotFoundException("User not found");
        }

        var getUserDto = _mapper.Map<GetUserDto>(user);
        return getUserDto;
    }
}

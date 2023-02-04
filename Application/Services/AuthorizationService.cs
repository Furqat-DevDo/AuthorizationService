using Core.Contexts;
using Domain.DTO.Authorization;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Services;

public class AuthorizationService : IAuthorizationService
{
    private readonly IApplicationDbContext _context;
    public async  Task<UserModel> RegisterUserAsyc(CreateUserDto userDto)
    {
        throw new NotImplementedException();
    }

    public async Task<UserModel> ConfirmUserAsyc(ConfirmationDto confirmationDto)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> IsUserExist(Guid userId,CancellationToken cancellationToken = default)
        => await _context.Users.AnyAsync(u => u.Id == userId, cancellationToken: cancellationToken);
}
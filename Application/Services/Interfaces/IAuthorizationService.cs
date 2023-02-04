using Domain.DTO.Authorization;
using Domain.Entities;
using Domain.Models;

namespace Core.Services;

public interface IAuthorizationService
{
    Task<UserModel> RegisterUserAsyc(CreateUserDto userDto);
    Task<UserModel> ConfirmUserAsyc(ConfirmationDto confirmationDto);
    Task<bool> IsUserExist(Guid userId ,CancellationToken cancellationToken = default);
}
using Core.DTO;
using Domain.Models;

namespace Core.Services;

public interface IAuthorizationService
{
    UserModel RegisterUserAsync(CreateUserDto userDto);
}
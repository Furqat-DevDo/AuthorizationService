using Core.DTO.Authorization;
using Domain.Models;

namespace Core.Services;

public interface IAuthorizationService
{
    UserModel RegisterUserAsyc(CreateUserDto userDto);
    
}
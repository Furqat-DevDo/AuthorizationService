using Core.DTO.Authorization;
using FluentValidation;

namespace SelfStudy.Validations;

public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
{
    public CreateUserDtoValidator()
    {
        
    }
}
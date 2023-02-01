using Core.DTO.Authorization;
using FluentValidation;

namespace SelfStudy.Validations;
public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
{
    public CreateUserDtoValidator()
    {
        RuleFor(m => m.Email).NotNull().When(m => string.IsNullOrEmpty(m.Phone));
        RuleFor(m => m.Phone).NotNull().When(m => string.IsNullOrEmpty(m.Email));
        RuleFor(m => m.PassWord).NotNull().NotEmpty();
    }
}
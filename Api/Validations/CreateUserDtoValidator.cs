using Core.DTO.Authorization;
using FluentValidation;

namespace SelfStudy.Validations;
public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
{
    public CreateUserDtoValidator()
    {
        RuleFor(a => a.Email).EmailAddress()
            .Null().When(a=>a.Phone is not null)
            .WithName("{Proprety}")
            .WithMessage("You should to enter Email or Phone");
        
        RuleFor(a => a.Phone)
            .Null().When(a=>a.Email is not null)
            .WithName("{Proprety}")
            .WithMessage("You should to enter Email or Phone");
    }
}
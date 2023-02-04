using System.Globalization;
using Core.Services;
using Domain.DTO.Authorization;
using FluentValidation;

namespace SelfStudy.Validations;

public class ConfirmationDtoValidator : AbstractValidator<ConfirmationDto>
{
    public ConfirmationDtoValidator(IAuthorizationService _authorizationService)
    {
        ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("uz-Latn-UZ");
        
        RuleFor(c => c.Otp).NotNull().NotEmpty().Length(6)
            .WithMessage("OTP must be valid");
        
        RuleFor(c => c.Id).MustAsync(async (id,cancellationToken) => 
            await _authorizationService.IsUserExist(id,cancellationToken)).WithMessage("User not found");
    }
}
using Core.Services;
using FluentValidation;
using SelfStudy.Validations;

namespace SelfStudy;

public static class ServiceExtensions
{
    public static IServiceCollection AddMyService(this IServiceCollection services)
    {
        services.AddScoped<IAuthorizationService, AuthorizationService>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddValidatorsFromAssemblyContaining<CreateUserDtoValidator>();
        return services;
    }
}
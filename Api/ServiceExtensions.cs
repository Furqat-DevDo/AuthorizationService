using System.Reflection;
using Core.Services;
using Domain.DTO.Authorization;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;
using SelfStudy.Validations;

namespace SelfStudy;

public static class ServiceExtensions
{
    
    public static IServiceCollection AddMyService(this IServiceCollection services)
    {
        services.AddScoped<IAuthorizationService, AuthorizationService>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddTransient<IValidator<CreateUserDto>, CreateUserDtoValidator>();
        services.AddTransient<IValidator<ConfirmationDto>, ConfirmationDtoValidator>();

        services.AddAutoMapper(typeof(Program).Assembly);
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Test API", Version = "v1" });
            c.EnableAnnotations();
        });
        
        return services;
    }
}
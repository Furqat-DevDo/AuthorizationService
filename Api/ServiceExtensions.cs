using System.Reflection;
using Core.Services;
using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;

namespace SelfStudy;

public static class ServiceExtensions
{
    public static IServiceCollection AddMyService(this IServiceCollection services)
    {
        services.AddScoped<IAuthorizationService, AuthorizationService>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        
        services.AddFluentValidation(fv =>
        {
            fv.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        });
        
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Test API", Version = "v1" });
            c.EnableAnnotations();
        });
        
        services.AddAutoMapper(typeof(Program).Assembly);
        
        return services;
    }
}
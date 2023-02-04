using Core.Contexts;
using Microsoft.EntityFrameworkCore;
using SelfStudy;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddDbContext<IApplicationDbContext,ApplicationDbContext>(options =>
            options.UseLazyLoadingProxies()
                .UseNpgsql(builder.Configuration.GetConnectionString("MyConnection")));

builder.Services.AddControllers()
    .AddJsonOptions(options => 
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull);

services.AddEndpointsApiExplorer();
services.AddMyService();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tes Api V1");
    });
}
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();

app.Run();


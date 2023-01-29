using Core.Contexts;
using Microsoft.EntityFrameworkCore;
using SelfStudy;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("MyConnection")));

services.AddMyService();

services.AddControllers();
services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tes Api V1");
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();


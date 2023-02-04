using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Contexts;
public class ApplicationDbContext : DbContext,IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base (options){}
    public DbSet<User> Users => Set<User>();
}
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Contexts;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base (options){}

    private DbSet<User> Users { get; set; }
}
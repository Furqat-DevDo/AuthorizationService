using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Contexts;
public class ApplicationDbContext : DbContext
{
    private DbSet<User> Users { get; set; }
}
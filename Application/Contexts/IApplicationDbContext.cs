using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Contexts;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
}
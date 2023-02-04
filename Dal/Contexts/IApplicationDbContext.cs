using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dal.Contexts;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
}
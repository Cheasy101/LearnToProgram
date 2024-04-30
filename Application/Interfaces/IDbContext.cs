using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces;

/// <summary>
/// Интерфейс БД контекста
/// </summary>
public interface IDbContext
{
 
    public DbSet<FeedbackFeed> FeedbackFeeds { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    
    public DbSet<User> Users { get; set; }

    public DbSet<Role> Roles { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken token);
}
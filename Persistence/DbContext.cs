using Application.Interfaces;
using Domain.Entities;
using Domain.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Persistence;

public class DbContext : IdentityDbContext<User, Role, Guid>, IDbContext
{
    public DbSet<Lesson> Lessons { get; set; } = default!;
    public DbSet<FeedbackFeed> FeedbackFeeds { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
       builder.Entity<Role>().HasData([DataContextSeed.TeacherRole,
           DataContextSeed.AdminRole, DataContextSeed.StudentRoleName]);
       builder.Entity<Lesson>().HasData(DataContextSeed.GetLessonSeeds());
       builder.Entity<FeedbackFeed>();
    }

    protected DbContext()
    {
    }

    public DbContext(DbContextOptions<DbContext> options) : base(options)
    {
    }
}
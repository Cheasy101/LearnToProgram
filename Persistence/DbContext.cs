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
    public DbSet<UserStats> UsersStats { get; set; } = default!;
    public DbSet<UserLessonHint> UserLessonHint { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Role>().HasData([
            DataContextSeed.TeacherRole,
            DataContextSeed.AdminRole,
            DataContextSeed.StudentRoleName
        ]);

        builder.Entity<Lesson>().HasData(DataContextSeed.GetLessonSeeds());
        builder.Entity<FeedbackFeed>();
        builder.Entity<UserStats>();

        builder.Entity<UserLessonHint>(entity =>
        {
            entity.ToTable("UserLessonHints");

            entity.HasKey(x => x.Id);

            entity.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(x => x.Lesson)
                .WithMany()
                .HasForeignKey(x => x.LessonId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasIndex(x => new { x.UserId, x.LessonId }).IsUnique();

            entity.Property(x => x.HintText)
                .HasMaxLength(1000)
                .IsRequired();

            entity.Property(x => x.AttemptsThreshold)
                .HasDefaultValue(3);
        });
    }

    protected DbContext()
    {
    }

    public DbContext(DbContextOptions<DbContext> options) : base(options)
    {
    }
}
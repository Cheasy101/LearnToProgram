using Domain.Seed;

namespace Application.Constants;

public static class Roles
{
    public static readonly string AdminRoleName = DataContextSeed.AdminRole.Name!;

    public static readonly string TeacherRoleName = DataContextSeed.TeacherRole.Name!;

    public static readonly string StudentRoleName = DataContextSeed.StudentRoleName.Name!;
}
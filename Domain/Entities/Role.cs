using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

/// <summary>
/// Роль юзера
/// </summary>
public class Role : IdentityRole<Guid>;
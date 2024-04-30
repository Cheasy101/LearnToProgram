using Domain.Abstractions;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

/// <summary>
/// Обычный пользователь
/// </summary>
public class User : IdentityUser<Guid>, IAuditableEntity
{
    /// <summary>
    /// Ссылка на фото
    /// </summary>
    public string? UserPhotoUrl { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
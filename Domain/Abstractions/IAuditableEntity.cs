namespace Domain.Abstractions;

public interface IAuditableEntity : IEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
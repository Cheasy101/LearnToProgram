namespace Contracts.Requests.Home.GetIndex;

public class FeedbackFeedDto
{
    public string FullName { get; set; } = default!;
    public string EmailAddress { get; set; } = default!;
    public string UserMessage { get; set; } = default!;
    
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
namespace Contracts.Requests.Hints;

public class GetLessonHintDto
{
    public string? HintText { get; set; }
    public int? AttemptsThreshold { get; set; }
}

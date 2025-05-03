namespace Contracts.Requests.Practice;

// CheckPracticeResponse.cs
public record CheckPracticeResponse(
    bool IsCorrect,
    int Attempts,
    string? SolutionCode,
    string? ExpectedOutput);
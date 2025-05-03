namespace Contracts.Requests.Practice;

// PracticeCheckResponse.cs
public record PracticeCheckResponse(
    bool IsCorrect,
    int Attempts,
    string? ExpectedOutput,
    string? SolutionCode);
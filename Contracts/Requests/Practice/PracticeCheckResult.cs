namespace Contracts.Requests.Practice;

public record PracticeCheckResult(
    bool IsSuccessful,
    int Attempts,
    string? ExpectedOutput,
    string? HintText);
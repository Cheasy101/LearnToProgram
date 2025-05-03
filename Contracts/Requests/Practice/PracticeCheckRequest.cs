namespace Contracts.Requests.Practice;

// PracticeCheckRequest.cs
public record PracticeCheckRequest(
    Guid LessonId,
    string UserCode,
    string UserOutput); // Код и вывод пользователя


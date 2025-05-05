namespace Contracts.Requests.lesson;

public class LessonPageResponseModel
{
    public GetLessonByIdDto LessonByIdDto { get; set; } = default!;
    public List<LessonsForSidebarDto> AllLessonsForSidebarDto { get; set; } = default!;

    public SubmitLessonAsDoneDto SubmitLessonAsDoneDto { get; set; } = default!;


    /// <summary>
    /// Текст подсказки для текущего пользователя (если есть)
    /// </summary>
    public string? HintText { get; set; }
}
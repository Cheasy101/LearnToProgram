namespace Contracts.Requests.lesson;

public class LessonPageResponseModel
{
    public GetLessonByIdDto LessonByIdDto { get; set; } = default!;
    public List<LessonsForSidebarDto>  AllLessonsForSidebarDto { get; set; } = default!;
}
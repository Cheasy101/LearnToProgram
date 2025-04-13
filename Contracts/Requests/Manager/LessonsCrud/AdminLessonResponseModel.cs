namespace Contracts.Requests.Manager.LessonsCrud;

public class AdminLessonResponseModel
{
    public List<AdminLessonListDto> Lessons { get; set; }
    public AdminLessonEditDto? EditLesson { get; set; }
}
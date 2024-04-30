namespace Contracts.Requests.Home.GetIndex;

public class GetCoursesResponseDto
{
    public List<GetCoursesResponseItemDto>? Courses { get; set; } = [];
}
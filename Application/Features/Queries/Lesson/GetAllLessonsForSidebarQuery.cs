using Contracts.Requests.Home.GetIndex;
using Contracts.Requests.lesson;
using MediatR;

namespace Application.Features.Queries.Lesson;

public class GetAllLessonsForSidebarQuery : IRequest<LessonPageResponseModel>
{
    
}
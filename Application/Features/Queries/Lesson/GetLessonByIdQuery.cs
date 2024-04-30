using Contracts.Requests.Home.GetIndex;
using Contracts.Requests.lesson;
using MediatR;

namespace Application.Features.Queries.Lesson;

public class GetLessonByIdQuery(Guid id) : IRequest<LessonPageResponseModel>
{
    public Guid Id { get; } = id;
    // public GetLessonByIdDto LessonByIdDto { get; set; } = lessonByIdDto;
}


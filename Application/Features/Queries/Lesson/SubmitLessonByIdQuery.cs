using Contracts.Requests.lesson;
using MediatR;

namespace Application.Features.Queries.Lesson;

public class SubmitLessonByIdQuery(SubmitLessonAsDoneDto submitLessonAsDoneDto) : IRequest<SubmitLessonAsDoneDto>
{
 public SubmitLessonAsDoneDto SubmitLessonAsDone { get; set; } = submitLessonAsDoneDto;
}
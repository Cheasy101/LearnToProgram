using Contracts.Requests.SharedStudentStats;
using MediatR;

namespace Application.Features.Queries.SharedStudentStats;

public record GetStudentProgressQuery(Guid UserId) : IRequest<StudentProgressResponse>;
using Contracts.Requests.Manager.LessonsCrud;
using MediatR;

namespace Application.Features.Queries.TeacherAndAdmin.crudLessons;

public class GetAdminLessonsQuery : IRequest<AdminLessonResponseModel>;

using Application.Interfaces;
using Contracts.Requests.Manager.LessonsCrud;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Commands.CrudLessons;


// Application/Features/Commands/Lesson/Admin
public class SaveLessonCommand(AdminLessonEditDto dto, Guid userId) : IRequest
{
    public AdminLessonEditDto Dto { get; } = dto;
    public Guid UserId { get; } = userId;
}


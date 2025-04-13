using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Commands.CrudLessons;

public class SaveLessonCommandHandler(IDbContext context) : IRequestHandler<SaveLessonCommand>
{
    public async Task Handle(SaveLessonCommand request, CancellationToken ct)
    {
        var dto = request.Dto;

        if (dto.Id == Guid.Empty)
        {
            // Create new
            var lesson = new Domain.Entities.Lesson
            {
                SmallDescription = dto.SmallDescription,
                Description = dto.Description,
                VideoLink = dto.VideoLink,
                // AuthorId = request.UserId
                LessonPhotoUrl = dto.PhotoLink
            };


            await context.Lessons.AddAsync(lesson, ct);
        }
        else
        {
            // Update existing
            var lesson = await context.Lessons.FirstOrDefaultAsync(x => x.Id == dto.Id, ct);
            if (lesson == null) throw new Exception("Lesson not found");

            lesson.SmallDescription = dto.SmallDescription;
            lesson.Description = dto.Description;
            lesson.VideoLink = dto.VideoLink;
            lesson.LessonPhotoUrl = dto.PhotoLink;
        }

        await context.SaveChangesAsync(ct);
    }
}
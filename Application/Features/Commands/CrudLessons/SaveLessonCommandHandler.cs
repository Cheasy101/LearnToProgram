using Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Commands.CrudLessons;

public class SaveLessonCommandHandler : IRequestHandler<SaveLessonCommand>
{
    private readonly IDbContext _context;
    private readonly IWebHostEnvironment _env;

    public SaveLessonCommandHandler(IDbContext context, IWebHostEnvironment env)
    {
        _context = context;
        _env = env;
    }

    public async Task Handle(SaveLessonCommand request, CancellationToken ct)
    {
        var dto = request.Dto;
        string? photoPath = null;

        // 🖼 Сохраняем фото, если файл выбран
        if (dto.PhotoFile != null && dto.PhotoFile.Length > 0)
        {
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.PhotoFile.FileName)}";
            var savePath = Path.Combine(_env.WebRootPath, "Photos", fileName);

            Directory.CreateDirectory(Path.GetDirectoryName(savePath)!);

            using var stream = new FileStream(savePath, FileMode.Create);
            await dto.PhotoFile.CopyToAsync(stream, ct);

            photoPath = $"/Photos/{fileName}";
        }

        if (dto.Id == Guid.Empty)
        {
            // 📌 Создание урока
            var lesson = new Domain.Entities.Lesson
            {
                SmallDescription = dto.SmallDescription,
                Description = dto.Description,
                VideoLink = dto.VideoLink,
                LessonPhotoUrl = photoPath // даже если null — ок, т.к. новый урок
            };

            await _context.Lessons.AddAsync(lesson, ct);
        }
        else
        {
            // ✏️ Обновление
            var lesson = await _context.Lessons.FirstOrDefaultAsync(x => x.Id == dto.Id, ct);
            if (lesson == null)
                throw new Exception("Lesson not found");

            // Обновляем только при наличии значений
            if (!string.IsNullOrWhiteSpace(dto.SmallDescription))
                lesson.SmallDescription = dto.SmallDescription;

            if (!string.IsNullOrWhiteSpace(dto.Description))
                lesson.Description = dto.Description;

            if (!string.IsNullOrWhiteSpace(dto.VideoLink))
                lesson.VideoLink = dto.VideoLink;

            if (!string.IsNullOrEmpty(photoPath))
                lesson.LessonPhotoUrl = photoPath; // если загружен новый файл — заменим
        }

        await _context.SaveChangesAsync(ct);
    }
}
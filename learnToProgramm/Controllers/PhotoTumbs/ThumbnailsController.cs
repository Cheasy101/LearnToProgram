using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace learnToProgramm.Controllers.PhotoTumbs;

[Route("thumbnails")]
public class ThumbnailsController : Controller
{
    private readonly string _photosPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Photos");
    private readonly string _thumbsPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "thumbs");

    [HttpGet("{fileName}")]
    public IActionResult GetThumbnail(string fileName)
    {
        var originalPath = Path.Combine(_photosPath, fileName);
        var thumbPath = Path.Combine(_thumbsPath, fileName);

        if (!System.IO.File.Exists(originalPath))
            return NotFound();

        // Если thumbnail уже существует, возвращаем его сразу
        if (System.IO.File.Exists(thumbPath))
        {
            var content = System.IO.File.ReadAllBytes(thumbPath);
            return File(content, "image/jpeg");
        }

        // Иначе создаём thumbnail
        Directory.CreateDirectory(_thumbsPath); // На всякий случай

        using var image = Image.Load(originalPath);
        image.Mutate(x => x.Resize(new ResizeOptions
        {
            Mode = ResizeMode.Max,
            Size = new Size(150, 150)
        }));

        using var ms = new MemoryStream();
        image.Save(ms, new JpegEncoder { Quality = 85 });
        ms.Seek(0, SeekOrigin.Begin);

        // Сохраняем thumbnail на диск
        System.IO.File.WriteAllBytes(thumbPath, ms.ToArray());

        return File(ms.ToArray(), "image/jpeg");
    }
}
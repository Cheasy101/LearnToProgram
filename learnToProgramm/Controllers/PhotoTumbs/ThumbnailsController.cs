using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;

namespace learnToProgramm.Controllers.PhotoTumbs;
[Route("thumbnails")]
public class ThumbnailsController : Controller
{
    [HttpGet("{fileName}")]
    public IActionResult GetThumbnail(string fileName)
    {
        var originalPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Photos", fileName);
        if (!System.IO.File.Exists(originalPath))
            return NotFound();

        using var image = Image.Load(originalPath);
        image.Mutate(x => x.Resize(new ResizeOptions
        {
            Mode = ResizeMode.Max,
            Size = new Size(150, 150) // можно изменить размер
        }));

        var ms = new MemoryStream();
        image.Save(ms, new JpegEncoder { Quality = 85 }); // можно поиграться с Quality
        ms.Seek(0, SeekOrigin.Begin);
        return File(ms.ToArray(), "image/jpeg");
    }
}
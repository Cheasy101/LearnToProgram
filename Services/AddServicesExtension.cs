using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Services;

public static class AddServicesExtension
{
    /// <summary>
    /// Добавление слоя сервисов
    /// </summary>
    /// <param name="services">IServiceCollection</param>
    /// <returns>IServiceCollection</returns>
    public static IServiceCollection AddServices(this IServiceCollection services)
        => services.AddScoped<IEmailSender, EmailSender.EmailSender>();
}
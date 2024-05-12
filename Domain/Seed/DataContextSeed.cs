using Domain.Entities;

namespace Domain.Seed;

/// <summary>
/// Базовые роли для БД
/// </summary>
public static class DataContextSeed
{
    /// <summary>
    /// Роль Админа
    /// </summary>
    public static readonly Role AdminRole = new()
    {
        Id = new Guid("4B960FC2-23BC-4003-A03D-552FBA0E579E"),
        Name = "Admin",
        NormalizedName = "ADMIN"
    };

    /// <summary>
    /// Роль препода
    /// </summary>
    public static readonly Role TeacherRole = new()
    {
        Id = new Guid("33F3F505-60E8-4656-AA3D-5F427192C489"),
        Name = "Teacher",
        NormalizedName = "TEACHER"
    };

    /// <summary>
    /// Роль студента
    /// </summary>
    public static readonly Role StudentRoleName = new()
    {
        Id = new Guid("6D8E2FFC-8500-407B-9FEE-0312CACBFB48"),
        Name = "Student",
        NormalizedName = "STUDENT"
    };

    /// <summary>
    /// Базовый сид лоя уроков 
    /// </summary>
    /// <returns></returns>
    public static Lesson[] GetLessonSeeds()
    {
        return
        [
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description =
                    "Объяснение того, что такое переменная и как её объявить. Основные операции с переменными, такие как присваивание, обновление и использование.",
                SmallDescription = "Переменные и операции с ними",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description =
                    "Введение в различные типы данных, такие как целые числа (integers), дробные числа (floats) и строки (strings). Объяснение различий между типами данных и как они влияют на операции, которые можно выполнять.",
                SmallDescription = "Типы данных",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description =
                    "Как получать данные от пользователя через консоль (ввод) и выводить результаты работы программы (вывод). Работа с функциями input() и print() для взаимодействия с пользователем.",
                SmallDescription = "Ввод и вывод данных",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description =
                    "Введение в операторы условия, такие как if, else и elif. Как использовать условные операторы для принятия решений в программе в зависимости от определённых условий.",
                SmallDescription = "Условные операторы",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description =
                    "Рассмотрение циклов, таких как цикл for и цикл while. Использование циклов для выполнения повторяющихся задач, таких как обход элементов списка или выполнение определённого количества итераций.",
                SmallDescription = "Циклы",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description =
                    "Понятие функций как набора инструкций, который может быть вызван из других частей программы. Создание и использование собственных функций для повторного использования кода.",
                SmallDescription = "Функции",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description =
                    "Введение в основные структуры данных, такие как списки (lists) и словари (dictionaries). Как использовать эти структуры данных для хранения и организации информации.",
                SmallDescription = "Структуры данных",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description =
                    "Как открывать, читать и записывать данные в файлы на компьютере. Различные режимы работы с файлами: чтение (read), запись (write), добавление (append) и т.д.",
                SmallDescription = "Работа с файлами",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description =
                    "Понятие и обработка исключений (exceptions) в программировании. Как использовать конструкцию try-except для предотвращения сбоев программы при возникновении ошибок.",
                SmallDescription = "Обработка ошибок",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description =
                    "Обзор базовых алгоритмических концепций, таких как сортировка и поиск. Введение в основные структуры данных, такие как стеки, очереди и деревья.",
                SmallDescription = "Основы алгоритмов и структур данных",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        ];
    }
}
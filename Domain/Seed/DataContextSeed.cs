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
                Description = "Объяснение того, что такое переменная и как её объявить. Основные операции с переменными, такие как присваивание, обновление и использование.",
                SmallDescription = "Переменные и операции с ними",
                LessonPhotoUrl = "photos/1.png",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                VideoLink = "https://www.youtube.com/embed/KUu8nTq0J3A?si=siLjWur0blEQ1PI7",
                PracticeTask = "Напишите программу, которая создает две переменные (a и b), присваивает им значения 5 и 3 соответственно, складывает их и выводит результат.",
                ExpectedOutput = "8",
                InitialCode = "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n        Console.WriteLine(\"Привет, мир!\");\n    }\n}"
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description = "Введение в различные типы данных, такие как целые числа (integers), дробные числа (floats) и строки (strings). Объяснение различий между типами данных и как они влияют на операции, которые можно выполнять.",
                SmallDescription = "Типы данных",
                LessonPhotoUrl = "photos/2.png",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                VideoLink = "https://www.youtube.com/embed/fNjVCSEXpDM?si=izfYrobvcVdf2ZAT",
                PracticeTask = "Создайте программу, которая объявляет переменные разных типов: целое число, дробное число, строку и булево значение, и выводит их значения.",
                ExpectedOutput = "10\n3.14\nHello\ntrue",
                InitialCode = "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Объявите переменные здесь\n    }\n}"
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description = "Как получать данные от пользователя через консоль (ввод) и выводить результаты работы программы (вывод). Работа с функциями input() и print() для взаимодействия с пользователем.",
                SmallDescription = "Ввод и вывод данных",
                LessonPhotoUrl = "photos/3.png",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                VideoLink = "https://www.youtube.com/embed/13SIaLUXicE?si=mgQcjoiYZJ2d428F",
                PracticeTask = "Напишите программу, которая запрашивает у пользователя его имя и возраст, а затем выводит приветствие в формате: \"Привет, [имя]! Тебе [возраст] лет.\"",
                ExpectedOutput = "Привет, Иван! Тебе 25 лет.",
                InitialCode = "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        Console.Write(\"Введите ваше имя: \");\n        // Ваш код здесь\n    }\n}"
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description = "Введение в операторы условия, такие как if, else и elif. Как использовать условные операторы для принятия решений в программе в зависимости от определённых условий.",
                SmallDescription = "Условные операторы",
                LessonPhotoUrl = "photos/4.png",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                VideoLink = "https://www.youtube.com/embed/agse5YvwKoo?si=a-fGwqwpwrFpP_vU",
                PracticeTask = "Напишите программу, которая проверяет, является ли число четным или нечетным, и выводит соответствующее сообщение.",
                ExpectedOutput = "Число 7 является нечетным",
                InitialCode = "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        int number = 7;\n        // Ваш код здесь\n    }\n}"
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description = "Рассмотрение циклов, таких как цикл for и цикл while. Использование циклов для выполнения повторяющихся задач, таких как обход элементов списка или выполнение определённого количества итераций.",
                SmallDescription = "Циклы",
                LessonPhotoUrl = "photos/5.png",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                VideoLink = "https://www.youtube.com/embed/MFSx0tbcRqc?si=D54HfFY_yJqrkk4L",
                PracticeTask = "Напишите программу, которая выводит все четные числа от 1 до 10.",
                ExpectedOutput = "2\n4\n6\n8\n10",
                InitialCode = "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n    }\n}"
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description = "Понятие функций как набора инструкций, который может быть вызван из других частей программы. Создание и использование собственных функций для повторного использования кода.",
                SmallDescription = "Функции",
                LessonPhotoUrl = "photos/6.png",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                VideoLink = "https://www.youtube.com/embed/Xk8vRnm6xtc?si=BTMMP8uw5BLyufAD",
                PracticeTask = "Создайте функцию, которая принимает два числа и возвращает их сумму. Вызовите эту функцию с аргументами 5 и 3 и выведите результат.",
                ExpectedOutput = "8",
                InitialCode = "using System;\n\npublic class Program\n{\n    // Объявите функцию здесь\n    \n    public static void Main()\n    {\n        // Вызовите функцию здесь\n    }\n}"
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description = "Введение в основные структуры данных, такие как списки (lists) и словари (dictionaries). Как использовать эти структуры данных для хранения и организации информации.",
                SmallDescription = "Структуры данных",
                LessonPhotoUrl = "photos/7.png",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                VideoLink = "https://www.youtube.com/embed/watch?v=GcAwk3TjoaE",
                PracticeTask = "Создайте список из трех элементов (строк) и выведите каждый элемент на новой строке.",
                ExpectedOutput = "Яблоко\nГруша\nБанан",
                InitialCode = "using System;\nusing System.Collections.Generic;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n    }\n}"
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description = "Как открывать, читать и записывать данные в файлы на компьютере. Различные режимы работы с файлами: чтение (read), запись (write), добавление (append) и т.д.",
                SmallDescription = "Работа с файлами",
                LessonPhotoUrl = "photos/8.png",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                VideoLink = "https://www.youtube.com/embed/rj9KHVLXaME?si=ktdv-uh5W8RnE0YQ",
                PracticeTask = "Напишите программу, которая создает файл 'test.txt' и записывает в него строку 'Hello, World!'.",
                ExpectedOutput = "Файл успешно создан и записан",
                InitialCode = "using System;\nusing System.IO;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n        Console.WriteLine(\"Файл успешно создан и записан\");\n    }\n}"
            },
            new  Lesson
            {
                Id = Guid.NewGuid(),
                Description = "Понятие и обработка исключений (exceptions) в программировании. Как использовать конструкцию try-except для предотвращения сбоев программы при возникновении ошибок.",
                SmallDescription = "Обработка ошибок",
                LessonPhotoUrl = "photos/9.png",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                VideoLink = "https://www.youtube.com/embed/dbxWEe4Ke58?si=VQczxwIAAMMtz4h6",
                PracticeTask = "Напишите программу, которая пытается разделить число на ноль и корректно обрабатывает исключение, выводя сообщение 'Деление на ноль невозможно'.",
                ExpectedOutput = "Деление на ноль невозможно",
                InitialCode = "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        try\n        {\n            // Ваш код здесь\n        }\n        catch (Exception ex)\n        {\n            Console.WriteLine(\"Деление на ноль невозможно\");\n        }\n    }\n}"
            },
            new Lesson
            {
                Id = Guid.NewGuid(),
                Description = "Обзор базовых алгоритмических концепций, таких как сортировка и поиск. Введение в основные структуры данных, такие как стеки, очереди и деревья.",
                SmallDescription = "Основы алгоритмов и структур данных",
                LessonPhotoUrl = "photos/10.png",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                VideoLink = "https://www.youtube.com/embed/CB9bS46vl04?si=1musPvHKSRQivKL7",
                PracticeTask = "Реализуйте алгоритм пузырьковой сортировки для массива [5, 3, 8, 1, 2] и выведите отсортированный массив.",
                ExpectedOutput = "1 2 3 5 8",
                InitialCode = "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        int[] array = { 5, 3, 8, 1, 2 };\n        // Ваш код здесь\n    }\n}"
            }
        ];
    }
}
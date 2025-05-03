using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_USER_CODE_FIELDS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("00683fcf-78d7-461f-8d76-ff87ea036d03"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1b59775e-824e-4189-97b0-f7d892e07cbf"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("66fae362-a8c6-4592-b6d5-b62a15a78488"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a3c513cc-d275-4a51-b789-a9e0a08521b6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b98e9d19-9a13-4f07-83f8-b4aa9fb11c52"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d36a124f-c1ba-43de-8865-7675f71f071a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d580d9fc-6e7b-43f6-8062-5d654b194641"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e1c8e062-94d6-4f87-ae4e-22bfff7a9bb7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e656678e-d5d1-41c8-bd98-6a7eb3fc9399"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ea57f077-fe11-4523-971c-6e62a9cc6596"));

            migrationBuilder.AddColumn<int>(
                name: "Attempts",
                table: "UsersStats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompletionTime",
                table: "UsersStats",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCode",
                table: "UsersStats",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpectedOutput",
                table: "Lessons",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InitialCode",
                table: "Lessons",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PracticeTask",
                table: "Lessons",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolutionCode",
                table: "Lessons",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "Description", "ExpectedOutput", "InitialCode", "LessonPhotoUrl", "PracticeTask", "SmallDescription", "SolutionCode", "UpdatedAt", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("18e389f6-d20f-45c0-916a-70347d7224f2"), new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5400), "Введение в операторы условия, такие как if, else и elif. Как использовать условные операторы для принятия решений в программе в зависимости от определённых условий.", "Число 7 является нечетным", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        int number = 7;\n        // Ваш код здесь\n    }\n}", "photos/4.png", "Напишите программу, которая проверяет, является ли число четным или нечетным, и выводит соответствующее сообщение.", "Условные операторы", null, new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5400), "https://www.youtube.com/embed/agse5YvwKoo?si=a-fGwqwpwrFpP_vU" },
                    { new Guid("3c79b1f3-5c49-4828-814c-5b20a8118107"), new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5410), "Введение в основные структуры данных, такие как списки (lists) и словари (dictionaries). Как использовать эти структуры данных для хранения и организации информации.", "Яблоко\nГруша\nБанан", "using System;\nusing System.Collections.Generic;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n    }\n}", "photos/7.png", "Создайте список из трех элементов (строк) и выведите каждый элемент на новой строке.", "Структуры данных", null, new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5410), "https://www.youtube.com/embed/watch?v=GcAwk3TjoaE" },
                    { new Guid("4eaf0cac-ef86-40f0-a7dc-6d0e4ff97f03"), new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5400), "Как получать данные от пользователя через консоль (ввод) и выводить результаты работы программы (вывод). Работа с функциями input() и print() для взаимодействия с пользователем.", "Привет, Иван! Тебе 25 лет.", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        Console.Write(\"Введите ваше имя: \");\n        // Ваш код здесь\n    }\n}", "photos/3.png", "Напишите программу, которая запрашивает у пользователя его имя и возраст, а затем выводит приветствие в формате: \"Привет, [имя]! Тебе [возраст] лет.\"", "Ввод и вывод данных", null, new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5400), "https://www.youtube.com/embed/13SIaLUXicE?si=mgQcjoiYZJ2d428F" },
                    { new Guid("619e8b2b-9830-414a-9bfd-fc920809898a"), new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5410), "Понятие функций как набора инструкций, который может быть вызван из других частей программы. Создание и использование собственных функций для повторного использования кода.", "8", "using System;\n\npublic class Program\n{\n    // Объявите функцию здесь\n    \n    public static void Main()\n    {\n        // Вызовите функцию здесь\n    }\n}", "photos/6.png", "Создайте функцию, которая принимает два числа и возвращает их сумму. Вызовите эту функцию с аргументами 5 и 3 и выведите результат.", "Функции", null, new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5410), "https://www.youtube.com/embed/Xk8vRnm6xtc?si=BTMMP8uw5BLyufAD" },
                    { new Guid("b1786ada-96ef-46cc-89cf-5f968bd7fd3f"), new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5400), "Рассмотрение циклов, таких как цикл for и цикл while. Использование циклов для выполнения повторяющихся задач, таких как обход элементов списка или выполнение определённого количества итераций.", "2\n4\n6\n8\n10", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n    }\n}", "photos/5.png", "Напишите программу, которая выводит все четные числа от 1 до 10.", "Циклы", null, new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5400), "https://www.youtube.com/embed/MFSx0tbcRqc?si=D54HfFY_yJqrkk4L" },
                    { new Guid("b8796325-045b-4391-a1e9-c8db8c8b6fff"), new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5430), "Обзор базовых алгоритмических концепций, таких как сортировка и поиск. Введение в основные структуры данных, такие как стеки, очереди и деревья.", "1 2 3 5 8", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        int[] array = { 5, 3, 8, 1, 2 };\n        // Ваш код здесь\n    }\n}", "photos/10.png", "Реализуйте алгоритм пузырьковой сортировки для массива [5, 3, 8, 1, 2] и выведите отсортированный массив.", "Основы алгоритмов и структур данных", null, new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5430), "https://www.youtube.com/embed/CB9bS46vl04?si=1musPvHKSRQivKL7" },
                    { new Guid("b9a32fff-d93c-41ae-beaa-1adc69e62044"), new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5390), "Введение в различные типы данных, такие как целые числа (integers), дробные числа (floats) и строки (strings). Объяснение различий между типами данных и как они влияют на операции, которые можно выполнять.", "10\n3.14\nHello\ntrue", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Объявите переменные здесь\n    }\n}", "photos/2.png", "Создайте программу, которая объявляет переменные разных типов: целое число, дробное число, строку и булево значение, и выводит их значения.", "Типы данных", null, new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5390), "https://www.youtube.com/embed/fNjVCSEXpDM?si=izfYrobvcVdf2ZAT" },
                    { new Guid("c4680e6f-0bd5-4f0c-9de6-531299224c7e"), new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5420), "Как открывать, читать и записывать данные в файлы на компьютере. Различные режимы работы с файлами: чтение (read), запись (write), добавление (append) и т.д.", "Файл успешно создан и записан", "using System;\nusing System.IO;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n        Console.WriteLine(\"Файл успешно создан и записан\");\n    }\n}", "photos/8.png", "Напишите программу, которая создает файл 'test.txt' и записывает в него строку 'Hello, World!'.", "Работа с файлами", null, new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5420), "https://www.youtube.com/embed/rj9KHVLXaME?si=ktdv-uh5W8RnE0YQ" },
                    { new Guid("d236c998-c789-4fbb-b6fb-255816f4af63"), new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5380), "Объяснение того, что такое переменная и как её объявить. Основные операции с переменными, такие как присваивание, обновление и использование.", "8", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n        Console.WriteLine(\"Привет, мир!\");\n    }\n}", "photos/1.png", "Напишите программу, которая создает две переменные (a и b), присваивает им значения 5 и 3 соответственно, складывает их и выводит результат.", "Переменные и операции с ними", null, new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5380), "https://www.youtube.com/embed/KUu8nTq0J3A?si=siLjWur0blEQ1PI7" },
                    { new Guid("d4e1d86b-3790-4fb1-a0dd-ae0a316415fc"), new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5420), "Понятие и обработка исключений (exceptions) в программировании. Как использовать конструкцию try-except для предотвращения сбоев программы при возникновении ошибок.", "Деление на ноль невозможно", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        try\n        {\n            // Ваш код здесь\n        }\n        catch (Exception ex)\n        {\n            Console.WriteLine(\"Деление на ноль невозможно\");\n        }\n    }\n}", "photos/9.png", "Напишите программу, которая пытается разделить число на ноль и корректно обрабатывает исключение, выводя сообщение 'Деление на ноль невозможно'.", "Обработка ошибок", null, new DateTime(2025, 5, 3, 9, 43, 53, 329, DateTimeKind.Utc).AddTicks(5420), "https://www.youtube.com/embed/dbxWEe4Ke58?si=VQczxwIAAMMtz4h6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("18e389f6-d20f-45c0-916a-70347d7224f2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3c79b1f3-5c49-4828-814c-5b20a8118107"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("4eaf0cac-ef86-40f0-a7dc-6d0e4ff97f03"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("619e8b2b-9830-414a-9bfd-fc920809898a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b1786ada-96ef-46cc-89cf-5f968bd7fd3f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b8796325-045b-4391-a1e9-c8db8c8b6fff"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b9a32fff-d93c-41ae-beaa-1adc69e62044"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c4680e6f-0bd5-4f0c-9de6-531299224c7e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d236c998-c789-4fbb-b6fb-255816f4af63"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d4e1d86b-3790-4fb1-a0dd-ae0a316415fc"));

            migrationBuilder.DropColumn(
                name: "Attempts",
                table: "UsersStats");

            migrationBuilder.DropColumn(
                name: "CompletionTime",
                table: "UsersStats");

            migrationBuilder.DropColumn(
                name: "UserCode",
                table: "UsersStats");

            migrationBuilder.DropColumn(
                name: "ExpectedOutput",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "InitialCode",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "PracticeTask",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "SolutionCode",
                table: "Lessons");

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "Description", "LessonPhotoUrl", "SmallDescription", "UpdatedAt", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("00683fcf-78d7-461f-8d76-ff87ea036d03"), new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6210), "Рассмотрение циклов, таких как цикл for и цикл while. Использование циклов для выполнения повторяющихся задач, таких как обход элементов списка или выполнение определённого количества итераций.", "photos/5.png", "Циклы", new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6210), "https://www.youtube.com/embed/MFSx0tbcRqc?si=D54HfFY_yJqrkk4L" },
                    { new Guid("1b59775e-824e-4189-97b0-f7d892e07cbf"), new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220), "Как открывать, читать и записывать данные в файлы на компьютере. Различные режимы работы с файлами: чтение (read), запись (write), добавление (append) и т.д.", "photos/8.png", "Работа с файлами", new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220), "https://www.youtube.com/embed/rj9KHVLXaME?si=ktdv-uh5W8RnE0YQ" },
                    { new Guid("66fae362-a8c6-4592-b6d5-b62a15a78488"), new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6200), "Как получать данные от пользователя через консоль (ввод) и выводить результаты работы программы (вывод). Работа с функциями input() и print() для взаимодействия с пользователем.", "photos/3.png", "Ввод и вывод данных", new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6200), "https://www.youtube.com/embed/13SIaLUXicE?si=mgQcjoiYZJ2d428F" },
                    { new Guid("a3c513cc-d275-4a51-b789-a9e0a08521b6"), new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6190), "Объяснение того, что такое переменная и как её объявить. Основные операции с переменными, такие как присваивание, обновление и использование.", "photos/1.png", "Переменные и операции с ними", new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6190), "https://www.youtube.com/embed/KUu8nTq0J3A?si=siLjWur0blEQ1PI7" },
                    { new Guid("b98e9d19-9a13-4f07-83f8-b4aa9fb11c52"), new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6230), "Обзор базовых алгоритмических концепций, таких как сортировка и поиск. Введение в основные структуры данных, такие как стеки, очереди и деревья.", "photos/10.png", "Основы алгоритмов и структур данных", new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6230), "https://www.youtube.com/embed/CB9bS46vl04?si=1musPvHKSRQivKL7" },
                    { new Guid("d36a124f-c1ba-43de-8865-7675f71f071a"), new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220), "Введение в основные структуры данных, такие как списки (lists) и словари (dictionaries). Как использовать эти структуры данных для хранения и организации информации.", "photos/7.png", "Структуры данных", new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220), "https://www.youtube.com/embed/watch?v=GcAwk3TjoaE" },
                    { new Guid("d580d9fc-6e7b-43f6-8062-5d654b194641"), new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6200), "Введение в различные типы данных, такие как целые числа (integers), дробные числа (floats) и строки (strings). Объяснение различий между типами данных и как они влияют на операции, которые можно выполнять.", "photos/2.png", "Типы данных", new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6200), "https://www.youtube.com/embed/fNjVCSEXpDM?si=izfYrobvcVdf2ZAT" },
                    { new Guid("e1c8e062-94d6-4f87-ae4e-22bfff7a9bb7"), new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6230), "Понятие и обработка исключений (exceptions) в программировании. Как использовать конструкцию try-except для предотвращения сбоев программы при возникновении ошибок.", "photos/9.png", "Обработка ошибок", new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6230), "https://www.youtube.com/embed/dbxWEe4Ke58?si=VQczxwIAAMMtz4h6" },
                    { new Guid("e656678e-d5d1-41c8-bd98-6a7eb3fc9399"), new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6210), "Введение в операторы условия, такие как if, else и elif. Как использовать условные операторы для принятия решений в программе в зависимости от определённых условий.", "photos/4.png", "Условные операторы", new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6210), "https://www.youtube.com/embed/agse5YvwKoo?si=a-fGwqwpwrFpP_vU" },
                    { new Guid("ea57f077-fe11-4523-971c-6e62a9cc6596"), new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220), "Понятие функций как набора инструкций, который может быть вызван из других частей программы. Создание и использование собственных функций для повторного использования кода.", "photos/6.png", "Функции", new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220), "https://www.youtube.com/embed/Xk8vRnm6xtc?si=BTMMP8uw5BLyufAD" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_UserLessonHint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserLessonHints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LessonId = table.Column<Guid>(type: "uuid", nullable: false),
                    HintText = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    AttemptsThreshold = table.Column<int>(type: "integer", nullable: false, defaultValue: 3)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLessonHints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLessonHints_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLessonHints_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "Description", "ExpectedOutput", "InitialCode", "LessonPhotoUrl", "PracticeTask", "SmallDescription", "SolutionCode", "UpdatedAt", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("031181a8-6b65-44bc-83f1-f5c4c2dbdfd2"), new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2810), "Обзор базовых алгоритмических концепций, таких как сортировка и поиск. Введение в основные структуры данных, такие как стеки, очереди и деревья.", "1 2 3 5 8", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        int[] array = { 5, 3, 8, 1, 2 };\n        // Ваш код здесь\n    }\n}", "photos/10.png", "Реализуйте алгоритм пузырьковой сортировки для массива [5, 3, 8, 1, 2] и выведите отсортированный массив.", "Основы алгоритмов и структур данных", null, new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2810), "https://www.youtube.com/embed/CB9bS46vl04?si=1musPvHKSRQivKL7" },
                    { new Guid("0d888140-67b1-40fa-9f4f-e2d7b6890cdb"), new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2760), "Объяснение того, что такое переменная и как её объявить. Основные операции с переменными, такие как присваивание, обновление и использование.", "8", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n        Console.WriteLine(\"Привет, мир!\");\n    }\n}", "photos/1.png", "Напишите программу, которая создает две переменные (a и b), присваивает им значения 5 и 3 соответственно, складывает их и выводит результат.", "Переменные и операции с ними", null, new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2760), "https://www.youtube.com/embed/KUu8nTq0J3A?si=siLjWur0blEQ1PI7" },
                    { new Guid("3f38795f-a68d-47db-9533-c5b16564fc96"), new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2800), "Как открывать, читать и записывать данные в файлы на компьютере. Различные режимы работы с файлами: чтение (read), запись (write), добавление (append) и т.д.", "Файл успешно создан и записан", "using System;\nusing System.IO;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n        Console.WriteLine(\"Файл успешно создан и записан\");\n    }\n}", "photos/8.png", "Напишите программу, которая создает файл 'test.txt' и записывает в него строку 'Hello, World!'.", "Работа с файлами", null, new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2800), "https://www.youtube.com/embed/rj9KHVLXaME?si=ktdv-uh5W8RnE0YQ" },
                    { new Guid("40c446f1-9143-4680-8343-bd26119b4dc9"), new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2780), "Рассмотрение циклов, таких как цикл for и цикл while. Использование циклов для выполнения повторяющихся задач, таких как обход элементов списка или выполнение определённого количества итераций.", "2\n4\n6\n8\n10", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n    }\n}", "photos/5.png", "Напишите программу, которая выводит все четные числа от 1 до 10.", "Циклы", null, new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2780), "https://www.youtube.com/embed/MFSx0tbcRqc?si=D54HfFY_yJqrkk4L" },
                    { new Guid("46b9142b-9179-4a32-a97c-3de4289c34a4"), new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2800), "Понятие и обработка исключений (exceptions) в программировании. Как использовать конструкцию try-except для предотвращения сбоев программы при возникновении ошибок.", "Деление на ноль невозможно", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        try\n        {\n            // Ваш код здесь\n        }\n        catch (Exception ex)\n        {\n            Console.WriteLine(\"Деление на ноль невозможно\");\n        }\n    }\n}", "photos/9.png", "Напишите программу, которая пытается разделить число на ноль и корректно обрабатывает исключение, выводя сообщение 'Деление на ноль невозможно'.", "Обработка ошибок", null, new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2800), "https://www.youtube.com/embed/dbxWEe4Ke58?si=VQczxwIAAMMtz4h6" },
                    { new Guid("61836fd1-6f07-4120-a92c-cb6b1a88bb9d"), new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2780), "Введение в операторы условия, такие как if, else и elif. Как использовать условные операторы для принятия решений в программе в зависимости от определённых условий.", "Число 7 является нечетным", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        int number = 7;\n        // Ваш код здесь\n    }\n}", "photos/4.png", "Напишите программу, которая проверяет, является ли число четным или нечетным, и выводит соответствующее сообщение.", "Условные операторы", null, new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2780), "https://www.youtube.com/embed/agse5YvwKoo?si=a-fGwqwpwrFpP_vU" },
                    { new Guid("a8106166-fdf7-44c5-97ca-8e8dd953efb9"), new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2790), "Введение в основные структуры данных, такие как списки (lists) и словари (dictionaries). Как использовать эти структуры данных для хранения и организации информации.", "Яблоко\nГруша\nБанан", "using System;\nusing System.Collections.Generic;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Ваш код здесь\n    }\n}", "photos/7.png", "Создайте список из трех элементов (строк) и выведите каждый элемент на новой строке.", "Структуры данных", null, new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2790), "https://www.youtube.com/embed/watch?v=GcAwk3TjoaE" },
                    { new Guid("c3681d05-7b21-4a23-b08e-87e88d1b1a2d"), new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2780), "Как получать данные от пользователя через консоль (ввод) и выводить результаты работы программы (вывод). Работа с функциями input() и print() для взаимодействия с пользователем.", "Привет, Иван! Тебе 25 лет.", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        Console.Write(\"Введите ваше имя: \");\n        // Ваш код здесь\n    }\n}", "photos/3.png", "Напишите программу, которая запрашивает у пользователя его имя и возраст, а затем выводит приветствие в формате: \"Привет, [имя]! Тебе [возраст] лет.\"", "Ввод и вывод данных", null, new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2780), "https://www.youtube.com/embed/13SIaLUXicE?si=mgQcjoiYZJ2d428F" },
                    { new Guid("d1a89d7e-946b-4233-a157-0a9f2347bc76"), new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2770), "Введение в различные типы данных, такие как целые числа (integers), дробные числа (floats) и строки (strings). Объяснение различий между типами данных и как они влияют на операции, которые можно выполнять.", "10\n3.14\nHello\ntrue", "using System;\n\npublic class Program\n{\n    public static void Main()\n    {\n        // Объявите переменные здесь\n    }\n}", "photos/2.png", "Создайте программу, которая объявляет переменные разных типов: целое число, дробное число, строку и булево значение, и выводит их значения.", "Типы данных", null, new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2770), "https://www.youtube.com/embed/fNjVCSEXpDM?si=izfYrobvcVdf2ZAT" },
                    { new Guid("f0164016-19ae-44b1-8428-8a03289bbcd8"), new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2790), "Понятие функций как набора инструкций, который может быть вызван из других частей программы. Создание и использование собственных функций для повторного использования кода.", "8", "using System;\n\npublic class Program\n{\n    // Объявите функцию здесь\n    \n    public static void Main()\n    {\n        // Вызовите функцию здесь\n    }\n}", "photos/6.png", "Создайте функцию, которая принимает два числа и возвращает их сумму. Вызовите эту функцию с аргументами 5 и 3 и выведите результат.", "Функции", null, new DateTime(2025, 5, 3, 20, 33, 46, 450, DateTimeKind.Utc).AddTicks(2790), "https://www.youtube.com/embed/Xk8vRnm6xtc?si=BTMMP8uw5BLyufAD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserLessonHints_LessonId",
                table: "UserLessonHints",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLessonHints_UserId_LessonId",
                table: "UserLessonHints",
                columns: new[] { "UserId", "LessonId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLessonHints");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("031181a8-6b65-44bc-83f1-f5c4c2dbdfd2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0d888140-67b1-40fa-9f4f-e2d7b6890cdb"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3f38795f-a68d-47db-9533-c5b16564fc96"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("40c446f1-9143-4680-8343-bd26119b4dc9"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("46b9142b-9179-4a32-a97c-3de4289c34a4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("61836fd1-6f07-4120-a92c-cb6b1a88bb9d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a8106166-fdf7-44c5-97ca-8e8dd953efb9"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c3681d05-7b21-4a23-b08e-87e88d1b1a2d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d1a89d7e-946b-4233-a157-0a9f2347bc76"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f0164016-19ae-44b1-8428-8a03289bbcd8"));

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
    }
}

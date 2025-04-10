using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_VideoLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0558ebbe-65a9-4089-81fb-cfba94e4278b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("10a1899c-aebb-4cf9-9500-905df5aa85e9"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2eb22afa-ea9c-47b3-bb0e-edcdd4e27d97"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("406abfd7-3f36-4f3d-9cfe-cd2bc0d13fb2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("783d6738-4718-4f80-93fb-2f69f4bbedb1"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9b1861f0-d9cc-4dd0-be99-54b339c4c06d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d63662ce-627b-4dec-afa9-2743c8faaf98"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d758ab7b-20d6-4294-b3c3-6f026085065a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e18f525f-9a73-48fb-a6f9-04b297ea651c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f57d533f-8107-42c2-acbe-c73f0875cbb2"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "Description", "LessonPhotoUrl", "SmallDescription", "UpdatedAt", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("0558ebbe-65a9-4089-81fb-cfba94e4278b"), new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8770), "Введение в операторы условия, такие как if, else и elif. Как использовать условные операторы для принятия решений в программе в зависимости от определённых условий.", "photos/4.png", "Условные операторы", new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8770), null },
                    { new Guid("10a1899c-aebb-4cf9-9500-905df5aa85e9"), new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8780), "Понятие функций как набора инструкций, который может быть вызван из других частей программы. Создание и использование собственных функций для повторного использования кода.", "photos/6.png", "Функции", new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8780), null },
                    { new Guid("2eb22afa-ea9c-47b3-bb0e-edcdd4e27d97"), new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8760), "Как получать данные от пользователя через консоль (ввод) и выводить результаты работы программы (вывод). Работа с функциями input() и print() для взаимодействия с пользователем.", "photos/3.png", "Ввод и вывод данных", new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8760), null },
                    { new Guid("406abfd7-3f36-4f3d-9cfe-cd2bc0d13fb2"), new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8750), "Объяснение того, что такое переменная и как её объявить. Основные операции с переменными, такие как присваивание, обновление и использование.", "photos/1.png", "Переменные и операции с ними", new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8750), null },
                    { new Guid("783d6738-4718-4f80-93fb-2f69f4bbedb1"), new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8790), "Понятие и обработка исключений (exceptions) в программировании. Как использовать конструкцию try-except для предотвращения сбоев программы при возникновении ошибок.", "photos/9.png", "Обработка ошибок", new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8790), null },
                    { new Guid("9b1861f0-d9cc-4dd0-be99-54b339c4c06d"), new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8760), "Введение в различные типы данных, такие как целые числа (integers), дробные числа (floats) и строки (strings). Объяснение различий между типами данных и как они влияют на операции, которые можно выполнять.", "photos/2.png", "Типы данных", new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8760), null },
                    { new Guid("d63662ce-627b-4dec-afa9-2743c8faaf98"), new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8780), "Введение в основные структуры данных, такие как списки (lists) и словари (dictionaries). Как использовать эти структуры данных для хранения и организации информации.", "photos/7.png", "Структуры данных", new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8780), null },
                    { new Guid("d758ab7b-20d6-4294-b3c3-6f026085065a"), new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8790), "Обзор базовых алгоритмических концепций, таких как сортировка и поиск. Введение в основные структуры данных, такие как стеки, очереди и деревья.", "photos/10.png", "Основы алгоритмов и структур данных", new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8790), null },
                    { new Guid("e18f525f-9a73-48fb-a6f9-04b297ea651c"), new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8770), "Рассмотрение циклов, таких как цикл for и цикл while. Использование циклов для выполнения повторяющихся задач, таких как обход элементов списка или выполнение определённого количества итераций.", "photos/5.png", "Циклы", new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8770), null },
                    { new Guid("f57d533f-8107-42c2-acbe-c73f0875cbb2"), new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8780), "Как открывать, читать и записывать данные в файлы на компьютере. Различные режимы работы с файлами: чтение (read), запись (write), добавление (append) и т.д.", "photos/8.png", "Работа с файлами", new DateTime(2025, 4, 8, 22, 43, 14, 936, DateTimeKind.Utc).AddTicks(8780), null }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddFeedBackFeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("06e18157-6401-4c81-adf3-b6500a2c6eca"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3cf9ee7a-b51e-4cdb-a396-67f71b9bdd62"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("4b3dbf66-2a3f-4f3b-bf4a-5973804533fc"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5152a392-cb4e-4df7-bd9c-53c134179f03"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("51b872d8-05c8-4978-aeb7-81a42b55538f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6d212cb6-ba54-4681-9be7-f923d0a88d2b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9b4a80e5-d3b7-497c-87e3-77d394e0d72a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c91e9a08-aefe-4b6d-b554-e499f9bc9b39"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("cabf2674-99af-467b-8407-13c6bfd982bb"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f6c3f63c-1ed4-40b1-965a-1e1707790a76"));

            migrationBuilder.CreateTable(
                name: "FeedbackFeeds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    EmailAddress = table.Column<string>(type: "text", nullable: false),
                    UserMessage = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackFeeds", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "Description", "LessonPhotoUrl", "SmallDescription", "UpdatedAt", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("08492cf8-b4ae-4cda-b211-ea03c336af7a"), new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5443), "Введение в различные типы данных, такие как целые числа (integers), дробные числа (floats) и строки (strings). Объяснение различий между типами данных и как они влияют на операции, которые можно выполнять.", null, "Типы данных", new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5444), null },
                    { new Guid("12a369fd-92e1-430d-92e1-706f4d51a766"), new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5498), "Как открывать, читать и записывать данные в файлы на компьютере. Различные режимы работы с файлами: чтение (read), запись (write), добавление (append) и т.д.", null, "Работа с файлами", new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5499), null },
                    { new Guid("73d9b8ce-4765-46f1-ade7-beb7f88a146a"), new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5501), "Понятие и обработка исключений (exceptions) в программировании. Как использовать конструкцию try-except для предотвращения сбоев программы при возникновении ошибок.", null, "Обработка ошибок", new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5502), null },
                    { new Guid("77490330-56b9-4986-97d7-c3a0ad19ef5b"), new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5456), "Понятие функций как набора инструкций, который может быть вызван из других частей программы. Создание и использование собственных функций для повторного использования кода.", null, "Функции", new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5457), null },
                    { new Guid("839f2b9f-966e-40d3-82f1-097996a26344"), new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5504), "Обзор базовых алгоритмических концепций, таких как сортировка и поиск. Введение в основные структуры данных, такие как стеки, очереди и деревья.", null, "Основы алгоритмов и структур данных", new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5505), null },
                    { new Guid("b262cd9b-3f09-406c-8b07-81b46f645153"), new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5495), "Введение в основные структуры данных, такие как списки (lists) и словари (dictionaries). Как использовать эти структуры данных для хранения и организации информации.", null, "Структуры данных", new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5496), null },
                    { new Guid("be12b3ab-d5a4-435e-a87e-bbbd768d7754"), new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5450), "Введение в операторы условия, такие как if, else и elif. Как использовать условные операторы для принятия решений в программе в зависимости от определённых условий.", null, "Условные операторы", new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5451), null },
                    { new Guid("d9a0c048-da2a-4587-8612-f614f41e847c"), new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5447), "Как получать данные от пользователя через консоль (ввод) и выводить результаты работы программы (вывод). Работа с функциями input() и print() для взаимодействия с пользователем.", null, "Ввод и вывод данных", new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5448), null },
                    { new Guid("fb52f04b-d4b2-4a1d-8675-b92758bdedb6"), new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5311), "Объяснение того, что такое переменная и как её объявить. Основные операции с переменными, такие как присваивание, обновление и использование.", null, "Переменные и операции с ними", new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5316), null },
                    { new Guid("fd602f32-c761-4eae-a7c9-3fada47c21a8"), new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5453), "Рассмотрение циклов, таких как цикл for и цикл while. Использование циклов для выполнения повторяющихся задач, таких как обход элементов списка или выполнение определённого количества итераций.", null, "Циклы", new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5454), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedbackFeeds");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("08492cf8-b4ae-4cda-b211-ea03c336af7a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("12a369fd-92e1-430d-92e1-706f4d51a766"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("73d9b8ce-4765-46f1-ade7-beb7f88a146a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("77490330-56b9-4986-97d7-c3a0ad19ef5b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("839f2b9f-966e-40d3-82f1-097996a26344"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b262cd9b-3f09-406c-8b07-81b46f645153"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("be12b3ab-d5a4-435e-a87e-bbbd768d7754"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d9a0c048-da2a-4587-8612-f614f41e847c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("fb52f04b-d4b2-4a1d-8675-b92758bdedb6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("fd602f32-c761-4eae-a7c9-3fada47c21a8"));

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "Description", "LessonPhotoUrl", "SmallDescription", "UpdatedAt", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("06e18157-6401-4c81-adf3-b6500a2c6eca"), new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3423), "Введение в операторы условия, такие как if, else и elif. Как использовать условные операторы для принятия решений в программе в зависимости от определённых условий.", null, "Условные операторы", new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3424), null },
                    { new Guid("3cf9ee7a-b51e-4cdb-a396-67f71b9bdd62"), new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3432), "Введение в основные структуры данных, такие как списки (lists) и словари (dictionaries). Как использовать эти структуры данных для хранения и организации информации.", null, "Структуры данных", new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3433), null },
                    { new Guid("4b3dbf66-2a3f-4f3b-bf4a-5973804533fc"), new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3421), "Как получать данные от пользователя через консоль (ввод) и выводить результаты работы программы (вывод). Работа с функциями input() и print() для взаимодействия с пользователем.", null, "Ввод и вывод данных", new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3421), null },
                    { new Guid("5152a392-cb4e-4df7-bd9c-53c134179f03"), new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3407), "Объяснение того, что такое переменная и как её объявить. Основные операции с переменными, такие как присваивание, обновление и использование.", null, "Переменные и операции с ними", new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3414), null },
                    { new Guid("51b872d8-05c8-4978-aeb7-81a42b55538f"), new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3417), "Введение в различные типы данных, такие как целые числа (integers), дробные числа (floats) и строки (strings). Объяснение различий между типами данных и как они влияют на операции, которые можно выполнять.", null, "Типы данных", new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3418), null },
                    { new Guid("6d212cb6-ba54-4681-9be7-f923d0a88d2b"), new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3427), "Рассмотрение циклов, таких как цикл for и цикл while. Использование циклов для выполнения повторяющихся задач, таких как обход элементов списка или выполнение определённого количества итераций.", null, "Циклы", new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3427), null },
                    { new Guid("9b4a80e5-d3b7-497c-87e3-77d394e0d72a"), new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3430), "Понятие функций как набора инструкций, который может быть вызван из других частей программы. Создание и использование собственных функций для повторного использования кода.", null, "Функции", new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3430), null },
                    { new Guid("c91e9a08-aefe-4b6d-b554-e499f9bc9b39"), new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3454), "Понятие и обработка исключений (exceptions) в программировании. Как использовать конструкцию try-except для предотвращения сбоев программы при возникновении ошибок.", null, "Обработка ошибок", new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3455), null },
                    { new Guid("cabf2674-99af-467b-8407-13c6bfd982bb"), new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3451), "Как открывать, читать и записывать данные в файлы на компьютере. Различные режимы работы с файлами: чтение (read), запись (write), добавление (append) и т.д.", null, "Работа с файлами", new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3451), null },
                    { new Guid("f6c3f63c-1ed4-40b1-965a-1e1707790a76"), new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3458), "Обзор базовых алгоритмических концепций, таких как сортировка и поиск. Введение в основные структуры данных, такие как стеки, очереди и деревья.", null, "Основы алгоритмов и структур данных", new DateTime(2024, 4, 27, 21, 38, 38, 944, DateTimeKind.Utc).AddTicks(3459), null }
                });
        }
    }
}

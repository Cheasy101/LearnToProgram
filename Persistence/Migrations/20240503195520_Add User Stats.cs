using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUserStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "UsersStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LessonId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDone = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersStats_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersStats_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "Description", "LessonPhotoUrl", "SmallDescription", "UpdatedAt", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("0820dfee-163a-43d9-bdd7-dd39f646a724"), new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9352), "Введение в операторы условия, такие как if, else и elif. Как использовать условные операторы для принятия решений в программе в зависимости от определённых условий.", null, "Условные операторы", new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9352), null },
                    { new Guid("0cbfeb57-fbfa-41e5-a15e-7b6ed9ae11ce"), new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9333), "Объяснение того, что такое переменная и как её объявить. Основные операции с переменными, такие как присваивание, обновление и использование.", null, "Переменные и операции с ними", new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9341), null },
                    { new Guid("27ca8874-26f8-4bdc-99e1-9af0525f651e"), new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9373), "Понятие функций как набора инструкций, который может быть вызван из других частей программы. Создание и использование собственных функций для повторного использования кода.", null, "Функции", new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9374), null },
                    { new Guid("51be602d-624d-4ed7-af78-ab41902895d0"), new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9382), "Понятие и обработка исключений (exceptions) в программировании. Как использовать конструкцию try-except для предотвращения сбоев программы при возникновении ошибок.", null, "Обработка ошибок", new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9383), null },
                    { new Guid("806ec490-9e7e-4e44-8be5-8bd6e8e54a13"), new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9355), "Рассмотрение циклов, таких как цикл for и цикл while. Использование циклов для выполнения повторяющихся задач, таких как обход элементов списка или выполнение определённого количества итераций.", null, "Циклы", new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9355), null },
                    { new Guid("817ceacd-f3cb-4bd4-9f45-c0c12ff2693e"), new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9345), "Введение в различные типы данных, такие как целые числа (integers), дробные числа (floats) и строки (strings). Объяснение различий между типами данных и как они влияют на операции, которые можно выполнять.", null, "Типы данных", new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9345), null },
                    { new Guid("a755e381-fe45-4075-a8cb-38c5ad15df3b"), new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9348), "Как получать данные от пользователя через консоль (ввод) и выводить результаты работы программы (вывод). Работа с функциями input() и print() для взаимодействия с пользователем.", null, "Ввод и вывод данных", new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9349), null },
                    { new Guid("ced4698f-3f86-4abe-b8c8-2f7ea406a653"), new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9385), "Обзор базовых алгоритмических концепций, таких как сортировка и поиск. Введение в основные структуры данных, такие как стеки, очереди и деревья.", null, "Основы алгоритмов и структур данных", new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9386), null },
                    { new Guid("dcecf19d-16ee-4e53-a819-00f3c682df34"), new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9376), "Введение в основные структуры данных, такие как списки (lists) и словари (dictionaries). Как использовать эти структуры данных для хранения и организации информации.", null, "Структуры данных", new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9377), null },
                    { new Guid("e91f5c62-c7d3-435b-afad-3d963ed6aa83"), new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9379), "Как открывать, читать и записывать данные в файлы на компьютере. Различные режимы работы с файлами: чтение (read), запись (write), добавление (append) и т.д.", null, "Работа с файлами", new DateTime(2024, 5, 3, 19, 55, 19, 501, DateTimeKind.Utc).AddTicks(9380), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersStats_LessonId",
                table: "UsersStats",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersStats_UserId",
                table: "UsersStats",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersStats");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0820dfee-163a-43d9-bdd7-dd39f646a724"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0cbfeb57-fbfa-41e5-a15e-7b6ed9ae11ce"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("27ca8874-26f8-4bdc-99e1-9af0525f651e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("51be602d-624d-4ed7-af78-ab41902895d0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("806ec490-9e7e-4e44-8be5-8bd6e8e54a13"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("817ceacd-f3cb-4bd4-9f45-c0c12ff2693e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a755e381-fe45-4075-a8cb-38c5ad15df3b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ced4698f-3f86-4abe-b8c8-2f7ea406a653"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("dcecf19d-16ee-4e53-a819-00f3c682df34"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e91f5c62-c7d3-435b-afad-3d963ed6aa83"));

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
    }
}

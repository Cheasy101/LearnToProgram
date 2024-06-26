﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DbContext))]
    [Migration("20240430084635_Add FeedBack Feed")]
    partial class AddFeedBackFeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.FeedbackFeed", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserMessage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FeedbackFeeds");
                });

            modelBuilder.Entity("Domain.Entities.Lesson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("LessonPhotoUrl")
                        .HasColumnType("text");

                    b.Property<string>("SmallDescription")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("VideoLink")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fb52f04b-d4b2-4a1d-8675-b92758bdedb6"),
                            CreatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5311),
                            Description = "Объяснение того, что такое переменная и как её объявить. Основные операции с переменными, такие как присваивание, обновление и использование.",
                            SmallDescription = "Переменные и операции с ними",
                            UpdatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5316)
                        },
                        new
                        {
                            Id = new Guid("08492cf8-b4ae-4cda-b211-ea03c336af7a"),
                            CreatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5443),
                            Description = "Введение в различные типы данных, такие как целые числа (integers), дробные числа (floats) и строки (strings). Объяснение различий между типами данных и как они влияют на операции, которые можно выполнять.",
                            SmallDescription = "Типы данных",
                            UpdatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5444)
                        },
                        new
                        {
                            Id = new Guid("d9a0c048-da2a-4587-8612-f614f41e847c"),
                            CreatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5447),
                            Description = "Как получать данные от пользователя через консоль (ввод) и выводить результаты работы программы (вывод). Работа с функциями input() и print() для взаимодействия с пользователем.",
                            SmallDescription = "Ввод и вывод данных",
                            UpdatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5448)
                        },
                        new
                        {
                            Id = new Guid("be12b3ab-d5a4-435e-a87e-bbbd768d7754"),
                            CreatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5450),
                            Description = "Введение в операторы условия, такие как if, else и elif. Как использовать условные операторы для принятия решений в программе в зависимости от определённых условий.",
                            SmallDescription = "Условные операторы",
                            UpdatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5451)
                        },
                        new
                        {
                            Id = new Guid("fd602f32-c761-4eae-a7c9-3fada47c21a8"),
                            CreatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5453),
                            Description = "Рассмотрение циклов, таких как цикл for и цикл while. Использование циклов для выполнения повторяющихся задач, таких как обход элементов списка или выполнение определённого количества итераций.",
                            SmallDescription = "Циклы",
                            UpdatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5454)
                        },
                        new
                        {
                            Id = new Guid("77490330-56b9-4986-97d7-c3a0ad19ef5b"),
                            CreatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5456),
                            Description = "Понятие функций как набора инструкций, который может быть вызван из других частей программы. Создание и использование собственных функций для повторного использования кода.",
                            SmallDescription = "Функции",
                            UpdatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5457)
                        },
                        new
                        {
                            Id = new Guid("b262cd9b-3f09-406c-8b07-81b46f645153"),
                            CreatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5495),
                            Description = "Введение в основные структуры данных, такие как списки (lists) и словари (dictionaries). Как использовать эти структуры данных для хранения и организации информации.",
                            SmallDescription = "Структуры данных",
                            UpdatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5496)
                        },
                        new
                        {
                            Id = new Guid("12a369fd-92e1-430d-92e1-706f4d51a766"),
                            CreatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5498),
                            Description = "Как открывать, читать и записывать данные в файлы на компьютере. Различные режимы работы с файлами: чтение (read), запись (write), добавление (append) и т.д.",
                            SmallDescription = "Работа с файлами",
                            UpdatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5499)
                        },
                        new
                        {
                            Id = new Guid("73d9b8ce-4765-46f1-ade7-beb7f88a146a"),
                            CreatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5501),
                            Description = "Понятие и обработка исключений (exceptions) в программировании. Как использовать конструкцию try-except для предотвращения сбоев программы при возникновении ошибок.",
                            SmallDescription = "Обработка ошибок",
                            UpdatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5502)
                        },
                        new
                        {
                            Id = new Guid("839f2b9f-966e-40d3-82f1-097996a26344"),
                            CreatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5504),
                            Description = "Обзор базовых алгоритмических концепций, таких как сортировка и поиск. Введение в основные структуры данных, такие как стеки, очереди и деревья.",
                            SmallDescription = "Основы алгоритмов и структур данных",
                            UpdatedAt = new DateTime(2024, 4, 30, 8, 46, 32, 777, DateTimeKind.Utc).AddTicks(5505)
                        });
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("33f3f505-60e8-4656-aa3d-5f427192c489"),
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = new Guid("4b960fc2-23bc-4003-a03d-552fba0e579e"),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("6d8e2ffc-8500-407b-9fee-0312cacbfb48"),
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("UserPhotoUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

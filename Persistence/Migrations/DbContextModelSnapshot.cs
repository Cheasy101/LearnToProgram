﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DbContext))]
    partial class DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("a3c513cc-d275-4a51-b789-a9e0a08521b6"),
                            CreatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6190),
                            Description = "Объяснение того, что такое переменная и как её объявить. Основные операции с переменными, такие как присваивание, обновление и использование.",
                            LessonPhotoUrl = "photos/1.png",
                            SmallDescription = "Переменные и операции с ними",
                            UpdatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6190),
                            VideoLink = "https://www.youtube.com/embed/KUu8nTq0J3A?si=siLjWur0blEQ1PI7"
                        },
                        new
                        {
                            Id = new Guid("d580d9fc-6e7b-43f6-8062-5d654b194641"),
                            CreatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6200),
                            Description = "Введение в различные типы данных, такие как целые числа (integers), дробные числа (floats) и строки (strings). Объяснение различий между типами данных и как они влияют на операции, которые можно выполнять.",
                            LessonPhotoUrl = "photos/2.png",
                            SmallDescription = "Типы данных",
                            UpdatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6200),
                            VideoLink = "https://www.youtube.com/embed/fNjVCSEXpDM?si=izfYrobvcVdf2ZAT"
                        },
                        new
                        {
                            Id = new Guid("66fae362-a8c6-4592-b6d5-b62a15a78488"),
                            CreatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6200),
                            Description = "Как получать данные от пользователя через консоль (ввод) и выводить результаты работы программы (вывод). Работа с функциями input() и print() для взаимодействия с пользователем.",
                            LessonPhotoUrl = "photos/3.png",
                            SmallDescription = "Ввод и вывод данных",
                            UpdatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6200),
                            VideoLink = "https://www.youtube.com/embed/13SIaLUXicE?si=mgQcjoiYZJ2d428F"
                        },
                        new
                        {
                            Id = new Guid("e656678e-d5d1-41c8-bd98-6a7eb3fc9399"),
                            CreatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6210),
                            Description = "Введение в операторы условия, такие как if, else и elif. Как использовать условные операторы для принятия решений в программе в зависимости от определённых условий.",
                            LessonPhotoUrl = "photos/4.png",
                            SmallDescription = "Условные операторы",
                            UpdatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6210),
                            VideoLink = "https://www.youtube.com/embed/agse5YvwKoo?si=a-fGwqwpwrFpP_vU"
                        },
                        new
                        {
                            Id = new Guid("00683fcf-78d7-461f-8d76-ff87ea036d03"),
                            CreatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6210),
                            Description = "Рассмотрение циклов, таких как цикл for и цикл while. Использование циклов для выполнения повторяющихся задач, таких как обход элементов списка или выполнение определённого количества итераций.",
                            LessonPhotoUrl = "photos/5.png",
                            SmallDescription = "Циклы",
                            UpdatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6210),
                            VideoLink = "https://www.youtube.com/embed/MFSx0tbcRqc?si=D54HfFY_yJqrkk4L"
                        },
                        new
                        {
                            Id = new Guid("ea57f077-fe11-4523-971c-6e62a9cc6596"),
                            CreatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220),
                            Description = "Понятие функций как набора инструкций, который может быть вызван из других частей программы. Создание и использование собственных функций для повторного использования кода.",
                            LessonPhotoUrl = "photos/6.png",
                            SmallDescription = "Функции",
                            UpdatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220),
                            VideoLink = "https://www.youtube.com/embed/Xk8vRnm6xtc?si=BTMMP8uw5BLyufAD"
                        },
                        new
                        {
                            Id = new Guid("d36a124f-c1ba-43de-8865-7675f71f071a"),
                            CreatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220),
                            Description = "Введение в основные структуры данных, такие как списки (lists) и словари (dictionaries). Как использовать эти структуры данных для хранения и организации информации.",
                            LessonPhotoUrl = "photos/7.png",
                            SmallDescription = "Структуры данных",
                            UpdatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220),
                            VideoLink = "https://www.youtube.com/embed/watch?v=GcAwk3TjoaE"
                        },
                        new
                        {
                            Id = new Guid("1b59775e-824e-4189-97b0-f7d892e07cbf"),
                            CreatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220),
                            Description = "Как открывать, читать и записывать данные в файлы на компьютере. Различные режимы работы с файлами: чтение (read), запись (write), добавление (append) и т.д.",
                            LessonPhotoUrl = "photos/8.png",
                            SmallDescription = "Работа с файлами",
                            UpdatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6220),
                            VideoLink = "https://www.youtube.com/embed/rj9KHVLXaME?si=ktdv-uh5W8RnE0YQ"
                        },
                        new
                        {
                            Id = new Guid("e1c8e062-94d6-4f87-ae4e-22bfff7a9bb7"),
                            CreatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6230),
                            Description = "Понятие и обработка исключений (exceptions) в программировании. Как использовать конструкцию try-except для предотвращения сбоев программы при возникновении ошибок.",
                            LessonPhotoUrl = "photos/9.png",
                            SmallDescription = "Обработка ошибок",
                            UpdatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6230),
                            VideoLink = "https://www.youtube.com/embed/dbxWEe4Ke58?si=VQczxwIAAMMtz4h6"
                        },
                        new
                        {
                            Id = new Guid("b98e9d19-9a13-4f07-83f8-b4aa9fb11c52"),
                            CreatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6230),
                            Description = "Обзор базовых алгоритмических концепций, таких как сортировка и поиск. Введение в основные структуры данных, такие как стеки, очереди и деревья.",
                            LessonPhotoUrl = "photos/10.png",
                            SmallDescription = "Основы алгоритмов и структур данных",
                            UpdatedAt = new DateTime(2025, 4, 8, 23, 0, 58, 59, DateTimeKind.Utc).AddTicks(6230),
                            VideoLink = "https://www.youtube.com/embed/CB9bS46vl04?si=1musPvHKSRQivKL7"
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

            modelBuilder.Entity("Domain.Entities.UserStats", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDone")
                        .HasColumnType("boolean");

                    b.Property<Guid>("LessonId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersStats");
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

            modelBuilder.Entity("Domain.Entities.UserStats", b =>
                {
                    b.HasOne("Domain.Entities.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("User");
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

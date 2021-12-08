using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WeLearn.Data.Migrations
{
    public partial class AddQuizModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Points = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizzes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsCorrect = table.Column<bool>(type: "boolean", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Examination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Points = table.Column<int>(type: "integer", nullable: false),
                    QuizId = table.Column<int>(type: "integer", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "integer", nullable: false),
                    ApplicationUserId1 = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examination_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examination_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionQuiz",
                columns: table => new
                {
                    QuestionsId = table.Column<int>(type: "integer", nullable: false),
                    QuizzesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionQuiz", x => new { x.QuestionsId, x.QuizzesId });
                    table.ForeignKey(
                        name: "FK_QuestionQuiz_Questions_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionQuiz_Quizzes_QuizzesId",
                        column: x => x.QuizzesId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fdfe31d-852f-4d57-b05e-0df391490870", "AQAAAAEAACcQAAAAEM/CaOHh2JM82KTILz4RBscE3kKhiIaUL/MHi5xrDuRu8FiQHkZwKXVwGCIh3NuHpA==", "b041af42-09e5-4a0d-a8db-23de4bb88e23" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 406, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 406, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 406, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 406, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 7, 1, 47, 51, 407, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.CreateIndex(
                name: "IX_Answers_IsDeleted",
                table: "Answers",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Examination_ApplicationUserId1",
                table: "Examination",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Examination_IsDeleted",
                table: "Examination",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Examination_QuizId",
                table: "Examination",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionQuiz_QuizzesId",
                table: "QuestionQuiz",
                column: "QuizzesId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_IsDeleted",
                table: "Questions",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_CategoryId",
                table: "Quizzes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_IsDeleted",
                table: "Quizzes",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Examination");

            migrationBuilder.DropTable(
                name: "QuestionQuiz");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f63afff9-3e7d-46f0-be5a-85cd41c52c3b", "AQAAAAEAACcQAAAAENmfbeBZjBZT9GuHQ4dnXH7KEE9FWfkFMLuijY2st0ByVCqs9CMD2XRvdEes5EwKPA==", "490ce832-fded-416d-92ea-1691bf4fc945" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 146, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 6, 17, 2, 53, 147, DateTimeKind.Utc).AddTicks(1354));
        }
    }
}

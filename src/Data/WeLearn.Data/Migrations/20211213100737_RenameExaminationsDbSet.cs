using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WeLearn.Data.Migrations
{
    public partial class RenameExaminationsDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Examination");

            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Points = table.Column<int>(type: "integer", nullable: false),
                    QuizId = table.Column<int>(type: "integer", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examinations_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examinations_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28d17058-ae65-49a4-a134-4cb4d6f709ef", "AQAAAAEAACcQAAAAEHvPn67OB+QK+826nyXyDy4Z8CeT7JInGCDiGeaUHZPTS7Rh6MP5EsGVPijduTF+3g==", "e3970513-70f8-435e-8b26-3c7fabdf988b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 911, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 911, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 911, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 913, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 911, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 911, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 10, 7, 35, 912, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_ApplicationUserId",
                table: "Examinations",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_IsDeleted",
                table: "Examinations",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_QuizId",
                table: "Examinations",
                column: "QuizId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Examinations");

            migrationBuilder.CreateTable(
                name: "Examination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Points = table.Column<int>(type: "integer", nullable: false),
                    QuizId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examination_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be3b5672-ed4b-491d-bb9c-2027178d0fb4", "AQAAAAEAACcQAAAAEIVJWPaX9NqiqdV7M11GE+m3D4fJ/TnHgzdkL77UoO6Dg3S7Yf9+ov2yTsJ3RA9HYg==", "9bf131d4-8545-4de7-a7d2-a52b845c80ac" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 201, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 201, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 201, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 203, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 13, 8, 34, 56, 202, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.CreateIndex(
                name: "IX_Examination_ApplicationUserId",
                table: "Examination",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Examination_IsDeleted",
                table: "Examination",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Examination_QuizId",
                table: "Examination",
                column: "QuizId");
        }
    }
}

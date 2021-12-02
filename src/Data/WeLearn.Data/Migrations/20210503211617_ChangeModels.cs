using System;

using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Posts_PostId",
                table: "Reports");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0554303c-bf76-46df-8930-2f15ffd63058");

            migrationBuilder.RenameColumn(
                name: "VideoName",
                table: "Videos",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "VideoContentType",
                table: "Videos",
                newName: "ContentType");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Reports",
                newName: "LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_PostId",
                table: "Reports",
                newName: "IX_Reports_LessonId");

            migrationBuilder.RenameColumn(
                name: "MaterialName",
                table: "Materials",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Comments",
                newName: "LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                newName: "IX_Comments_LessonId");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "character varying(1500)", maxLength: 1500, nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Grade = table.Column<int>(type: "integer", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: true),
                    VideoId = table.Column<int>(type: "integer", nullable: false),
                    MaterialId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Lessons_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateModified", "Name", "NormalizedName" },
                values: new object[] { "6aa81e10-b03f-4061-b162-2c823fa8a29a", "de45acb0-204e-4ae3-9e52-b84283d60c72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c56a6ab2-f48c-42b3-b1d2-30b4b65f0fe4", "AQAAAAEAACcQAAAAEMslx2XoZvuR8S9agDIqXnmxELZfua1EOVTBMAmfOh8b9j34x2DECHQkrrpwd1+IRw==", "cece20fc-49a8-441e-aaa9-9133bf628221" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "DateCreated", "DateDeleted", "DateModified", "Description", "Grade", "IsDeleted", "MaterialId", "Name", "VideoId" },
                values: new object[,]
                {
                    { 15, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 15, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7651), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pigments, brushes, bases, matrices.", 0, false, 15, "Painting", 15 },
                    { 16, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 16, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7653), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creating a new business, bearing most of the risks and enjoying most of the rewards.", 0, false, 16, "Entrepreneurship", 16 },
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 1, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(6130), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about pronouns and when to use them.", 0, false, 1, "Pronouns, types", 1 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 2, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7572), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A natural number greater than 1 that is not a product of two smaller natural numbers.", 0, false, 2, "Prime numbers", 2 },
                    { 4, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 4, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7578), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data analysis.", 0, false, 4, "Excel", 4 },
                    { 5, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 5, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7580), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern European Countries. Their iconomic growth and political stances. Ukraine.", 0, false, 5, "Ukraine, Eastern Europe", 5 },
                    { 6, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 6, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7581), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kicking a ball on the field.", 0, false, 6, "Football", 6 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 3, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7576), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "About the C# language and the .NET development Platform. First steps.", 0, false, 3, "Developing with C#", 3 },
                    { 8, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 8, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7584), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about rights of the people.", 0, false, 8, "Human rights", 8 },
                    { 9, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 9, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7641), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We use modals to show if we believe something is certain, possible or impossible.", 0, false, 9, "Modal verbs", 9 },
                    { 10, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 10, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7643), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about the verbs of motion and when to use them.", 0, false, 10, "Verbs of motion", 10 },
                    { 11, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 11, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7644), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A brief peek into our ancestors' life.", 0, false, 11, "Peek in the past", 11 },
                    { 12, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 12, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7646), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lesson about the different types of cells and their differences.", 0, false, 12, "Cells. Prokaryotic and Eukaryotic", 12 },
                    { 13, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 13, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7647), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lesson about acids, they effects on the environtment and usage cases.", 0, false, 13, "Acids, Bases and pH", 13 },
                    { 14, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 14, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7649), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genres, instruments and notation.", 0, false, 14, "Popular music", 14 },
                    { 7, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 7, new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(7583), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A peek into Shakespere's art.", 0, false, 7, "William Shakespere's 106 sonnet", 7 },
                });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 373, DateTimeKind.Utc).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 16, 16, 374, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ApplicationUserId",
                table: "Lessons",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CategoryId",
                table: "Lessons",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_MaterialId",
                table: "Lessons",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_VideoId",
                table: "Lessons",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Lessons_LessonId",
                table: "Reports",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Lessons_LessonId",
                table: "Reports");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aa81e10-b03f-4061-b162-2c823fa8a29a");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Videos",
                newName: "VideoName");

            migrationBuilder.RenameColumn(
                name: "ContentType",
                table: "Videos",
                newName: "VideoContentType");

            migrationBuilder.RenameColumn(
                name: "LessonId",
                table: "Reports",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_LessonId",
                table: "Reports",
                newName: "IX_Reports_PostId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Materials",
                newName: "MaterialName");

            migrationBuilder.RenameColumn(
                name: "LessonId",
                table: "Comments",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_LessonId",
                table: "Comments",
                newName: "IX_Comments_PostId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "character varying(1500)", maxLength: 1500, nullable: false),
                    Grade = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    MaterialId = table.Column<int>(type: "integer", nullable: false),
                    PostName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    VideoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateModified", "Name", "NormalizedName" },
                values: new object[] { "0554303c-bf76-46df-8930-2f15ffd63058", "9439310c-b4dc-4820-98bc-44fcc5d227d5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ff88e53-f59a-4fdd-b979-a1042102a0db", "AQAAAAEAACcQAAAAEJSCZ+c89KfRDby/rkyfWGz4K7Qn/lSche7xVnfcBWQbd+SHKihXb4uRYV+2SG69IA==", "0ff6a556-e375-41ec-a6aa-c0e74041d1fa" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 297, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 297, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 297, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "DateCreated", "DateDeleted", "DateModified", "Description", "Grade", "IsDeleted", "MaterialId", "PostName", "VideoId" },
                values: new object[,]
                {
                    { 16, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 16, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7780), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creating a new business, bearing most of the risks and enjoying most of the rewards.", 0, false, 16, "Entrepreneurship", 16 },
                    { 15, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 15, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7779), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pigments, brushes, bases, matrices.", 0, false, 15, "Painting", 15 },
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 1, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(6564), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about pronouns and when to use them.", 0, false, 1, "Pronouns, types", 1 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 2, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7757), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A natural number greater than 1 that is not a product of two smaller natural numbers.", 0, false, 2, "Prime numbers", 2 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 3, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7760), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "About the C# language and the .NET development Platform. First steps.", 0, false, 3, "Developing with C#", 3 },
                    { 4, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 4, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7762), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data analysis.", 0, false, 4, "Excel", 4 },
                    { 5, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 5, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7764), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern European Countries. Their iconomic growth and political stances. Ukraine.", 0, false, 5, "Ukraine, Eastern Europe", 5 },
                    { 6, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 6, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7765), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kicking a ball on the field.", 0, false, 6, "Football", 6 },
                    { 7, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 7, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7767), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A peek into Shakespere's art.", 0, false, 7, "William Shakespere's 106 sonnet", 7 },
                    { 8, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 8, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7768), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about rights of the people.", 0, false, 8, "Human rights", 8 },
                    { 9, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 9, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7770), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We use modals to show if we believe something is certain, possible or impossible.", 0, false, 9, "Modal verbs", 9 },
                    { 10, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 10, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7771), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about the verbs of motion and when to use them.", 0, false, 10, "Verbs of motion", 10 },
                    { 11, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 11, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7773), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A brief peek into our ancestors' life.", 0, false, 11, "Peek in the past", 11 },
                    { 12, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 12, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7774), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lesson about the different types of cells and their differences.", 0, false, 12, "Cells. Prokaryotic and Eukaryotic", 12 },
                    { 13, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 13, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7775), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lesson about acids, they effects on the environtment and usage cases.", 0, false, 13, "Acids, Bases and pH", 13 },
                    { 14, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 14, new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(7777), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genres, instruments and notation.", 0, false, 14, "Popular music", 14 }
                });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 297, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 297, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 297, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 20, 0, 47, 298, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_MaterialId",
                table: "Posts",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_VideoId",
                table: "Posts",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Posts_PostId",
                table: "Reports",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

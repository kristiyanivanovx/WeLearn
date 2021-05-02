using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangesInDatabaseSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ab02d06-69d3-4c1b-80ef-9541915f97b0", "AQAAAAEAACcQAAAAEGOPce3x3uUFJ+IlDgDtu9+2lhp+E6Lp2AQ+vBl62FRIR80Vt3Nu1IMshhaFUqsoBg==", "29df5fc6-681e-4d5b-8077-5b1e31a4369b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "DateCreated", "DateDeleted", "DateModified" },
                values: new object[] { 17, "Others", new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6891), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 434, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 434, DateTimeKind.Utc).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 434, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(6951), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Teaching" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8360), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Teaching" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8364), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Coding" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8366), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Office Suite" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8367), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Ukraine" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8369), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Football" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8534), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Literature" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8537), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Human Rights" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8540), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Modal Verbs" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8541), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Russian Language" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8542), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "History" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8544), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Biology" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8545), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Chemistry" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8546), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Music" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8547), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Painting" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8549), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip", "Entrepreneurship" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                columns: new[] { "DateCreated", "PostName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3386), "Popular music" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(8258), "/uploads/videos/teaching1.mp4", "Teaching" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9322), "/uploads/videos/man-teaching.mp4", "Teaching" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9326), "/uploads/videos/coding.mp4", "Coding" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9327), "/uploads/videos/office-suite.mp4", "Office Suite" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9328), "/uploads/videos/eastern-europe.mp4", "Ukraine" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9330), "/uploads/videos/football.mp4", "Football" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9331), "/uploads/videos/literature.mp4", "Literature" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9332), "/uploads/videos/human-rights.mp4", "Human Rights" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9333), "/uploads/videos/modal-verbs.mp4", "Modal Verbs" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9334), "/uploads/videos/russian-language.mp4", "Russian Language" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9335), "/uploads/videos/history.mp4", "History" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9336), "/uploads/videos/biology.mp4", "Biology" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9337), "/uploads/videos/chemistry.mp4", "Chemistry" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9338), "/uploads/videos/music.mp4", "Music" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9339), "/uploads/videos/painting.mp4", "Painting" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9341), "/uploads/videos/entrepreneurship.mp4", "Entrepreneurship" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e3c5733-5dd5-4cb4-90e5-2133a0d4ce8e", "AQAAAAEAACcQAAAAEP1E0HzLRR/KzYvM83wIU0nAisIBhkFGojjt+9xX4uPsRTQt3w9poPVQK1I34FxSww==", "63ea8d1a-43ec-4b29-ba5a-2b17cd4a3ced" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 638, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 638, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 638, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(1980), "https://images.unsplash.com/photo-1598350740930-8dc9c2e1774a?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=1350&q=80", "Whitey" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2767), "https://images.unsplash.com/photo-1598125445316-6aab4ec2b38c?ixid=MXwxMjA3fDB8MHxzZWFyY2h8MTA5fHxzYW1wbGV8ZW58MHx8MHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", "Rocks" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2770), "https://images.unsplash.com/photo-1615220368123-9bb8faf4221b?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1302&q=80", "Fancy Setup" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2771), "https://images.unsplash.com/photo-1532365673558-f9bb768644e7?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Greeny" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2773), "https://images.unsplash.com/photo-1598125445561-f1ab380e2cc3?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=1350&q=80", "Textile" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2774), "https://images.unsplash.com/photo-1598350742412-8fe67cd5375b?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=1350&q=80", "Concrete Building" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2775), "https://images.unsplash.com/photo-1598125442810-7d196739bb5b?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Moss" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2776), "https://images.unsplash.com/photo-1529321044792-949d1f03e61e?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1490&q=80", "Fire" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2777), "https://images.unsplash.com/photo-1600716051809-e997e11a5d52?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1333&q=80", "Lemons" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2778), "https://images.unsplash.com/photo-1561336313-0bd5e0b27ec8?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Coffee" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2779), "https://images.unsplash.com/photo-1525534240745-6b6f65e8a25f?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1490&q=80", "Flags" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2780), "https://images.unsplash.com/photo-1562589539-346d763b0513?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=676&q=80", "House" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2781), "https://images.unsplash.com/photo-1598125444907-f01590d16db5?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Snail" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2782), "https://images.unsplash.com/photo-1567796422106-8f577f1b715b?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=675&q=80", "Jars" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2783), "https://images.unsplash.com/photo-1524419986249-348e8fa6ad4a?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Nightcity" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                columns: new[] { "DateCreated", "Link", "MaterialName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2784), "https://images.unsplash.com/photo-1558387886-d6988f49a2e0?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Statue" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                columns: new[] { "DateCreated", "PostName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(965), "Medieval music" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(6532), "/uploads/videos/sample.mp4", "Whitey" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7319), "/uploads/videos/sample2.mp4", "Rocks" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7323), "/uploads/videos/sample.mp4", "Fancy Setup" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7324), "/uploads/videos/sample2.mp4", "Greeny" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7327), "/uploads/videos/sample.mp4", "Textile" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7328), "/uploads/videos/sample2.mp4", "Concrete Building" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7329), "/uploads/videos/sample.mp4", "Moss" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7330), "/uploads/videos/sample2.mp4", "Fire" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7331), "/uploads/videos/sample.mp4", "Lemons" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7332), "/uploads/videos/sample2.mp4", "Coffee" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7334), "/uploads/videos/sample.mp4", "Flags" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7335), "/uploads/videos/sample2.mp4", "House" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7336), "/uploads/videos/sample.mp4", "Snail" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7337), "/uploads/videos/sample2.mp4", "Jars" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7338), "/uploads/videos/sample.mp4", "Nightcity" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                columns: new[] { "DateCreated", "Link", "VideoName" },
                values: new object[] { new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7339), "/uploads/videos/sample2.mp4", "Statue" });
        }
    }
}

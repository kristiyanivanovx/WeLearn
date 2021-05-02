using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AnotherChangeInDatabaseSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efd159b7-726c-43f1-95bd-b146dfccd7cd", "AQAAAAEAACcQAAAAEOHz1KH/2UGGO2uxI2PcMeIbjz6mCY2djgBI4NJ/pp+E1P1Bb79jlR6CEDRU6AWn0Q==", "5fbd32e3-ca84-4236-8f26-c011d2ff7d6a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 957, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(3642), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4404), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4407), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4408), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4409), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4410), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4412), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4413), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4414), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4415), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4416), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4417), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4418), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4419), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4420), "..." });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4421), "..." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9243));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(6891));

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
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(6951), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8360), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8364), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8366), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8367), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8369), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8534), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8537), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8540), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8541), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8542), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8544), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8545), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8546), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8547), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(8549), "/uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip" });

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
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 436, DateTimeKind.Utc).AddTicks(3386));

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
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 8, 42, 435, DateTimeKind.Utc).AddTicks(9341));
        }
    }
}

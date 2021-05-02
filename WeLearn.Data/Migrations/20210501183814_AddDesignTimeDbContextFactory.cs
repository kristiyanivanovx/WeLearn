using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddDesignTimeDbContextFactory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(2784));

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
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 640, DateTimeKind.Utc).AddTicks(965));

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
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 18, 38, 13, 639, DateTimeKind.Utc).AddTicks(7339));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d2c348c-1425-4c9d-8e32-8bddb43a356c", "AQAAAAEAACcQAAAAELzZa3VYwx9LQP706k0b30Neg+gp19cXcV3r4Q7+LsO7C4ht5FVmm6pXCAsUBATYMQ==", "6820c8a5-51a2-4304-910f-669b2e484ae8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 749, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8950));
        }
    }
}

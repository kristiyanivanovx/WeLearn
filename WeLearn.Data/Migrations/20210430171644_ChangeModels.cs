using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d9c49b3-1076-4dec-bfa8-cce246db43e0", "AQAAAAEAACcQAAAAELL/mWlCqgrDHFl083oghbXArjfkximGiG/9vZp4XE1w5S7gc6kYdcqamdz3oS+GrQ==", "d8b9c8e7-29f9-40fe-aaad-32c246885edd" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 17, 16, 43, 450, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 17, 16, 43, 450, DateTimeKind.Utc).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 17, 16, 43, 450, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 17, 16, 43, 450, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 17, 16, 43, 451, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 17, 16, 43, 451, DateTimeKind.Utc).AddTicks(613));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3acf53a7-41f3-41d5-bdbe-2efed6ce41f7", "AQAAAAEAACcQAAAAENzcyUsd151lfYsjSz7rfk3e8qeUVyM6zIjKO7eKB1lLuYs1VsM761mOC6p5iZHV6A==", "c52529a9-ae59-41a0-9322-f04279952387" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 13, 10, 49, 528, DateTimeKind.Utc).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 13, 10, 49, 528, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 13, 10, 49, 528, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 13, 10, 49, 528, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 13, 10, 49, 528, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 4, 30, 13, 10, 49, 528, DateTimeKind.Utc).AddTicks(6347));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeSeedDataInComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af7d6864-180c-40d4-8551-d6c5316fba04", "AQAAAAEAACcQAAAAEPZAFFlctXKnf88TFriP/bfgRH0xhhmAU9A/K2eSlNMdcZmpQpvcsMXap4EMPO1dCQ==", "63a46992-3f34-44a6-940f-6fe2057472ae" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

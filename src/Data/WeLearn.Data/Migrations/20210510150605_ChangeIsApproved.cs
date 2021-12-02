using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeIsApproved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e616094-80d9-42fc-bd71-7b45bebce02c", "AQAAAAEAACcQAAAAEJzrjb98x+OFJtz6V7yZvcJ1XdOjRrOr8NrRbwjjEYf7wR6H4BcGNE0RSJ4rzpkt4A==", "90cc8be2-23b8-4db0-8fff-a6c68b552708" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 767, DateTimeKind.Utc).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 767, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 767, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 767, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 767, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3085));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021efabf-2ca8-4f0c-ab3d-2bba8876c7b0", "AQAAAAEAACcQAAAAELdOrX8rP+jKR1TpMEinqn7COS0UAkBH6dUcNCcIJX2Jy2qAmU55pWMR5jVT3jLfkQ==", "8547212a-a169-4ef4-9efb-5567431bee29" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 940, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8423));
        }
    }
}

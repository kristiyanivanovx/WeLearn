using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class MakeDbSetsVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af5d4bc3-bcbb-4ede-8e2c-1af23f331d5a", "AQAAAAEAACcQAAAAEIjCCrorvCwi4A9MOAX6f4C2WRiIN5Cdd88d6Cbjt7Qjra+HuKAfefVpG7NnElYljg==", "0d677ee9-77b9-4e15-8e6d-73ed524ae9de" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 680, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 680, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 680, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 682, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 12, 14, 26, 20, 681, DateTimeKind.Utc).AddTicks(8316));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9003c295-fd12-4e69-82d4-46d71f37e156", "AQAAAAEAACcQAAAAEJMvsPO0pfoNq0oasu6KndoUQT4YYvg1/RV+v0t14bFGdx//Cw4cRqhcGt5fiIsMng==", "d020e258-4e72-42f3-97b5-9fc6f85376a8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 74, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 76, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 14, 3, 1, 75, DateTimeKind.Utc).AddTicks(9497));
        }
    }
}

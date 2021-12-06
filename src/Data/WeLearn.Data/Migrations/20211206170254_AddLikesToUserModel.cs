﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddLikesToUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41bd33f1-26be-470e-8759-931fe279288a", "AQAAAAEAACcQAAAAEF4LDvLaCZ0TMZwSaqLC/5AWI8kOgG9MqUb61HHtvLNsSE//mcqr4PUfxpGlWmz51Q==", "f0714a56-7a58-4dc9-afe0-175e02bbdd2f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 69, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 23, 18, 40, 70, DateTimeKind.Utc).AddTicks(1200));
        }
    }
}

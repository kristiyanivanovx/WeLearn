using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeFluentApiSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Materials_MaterialId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Videos_VideoId",
                table: "Lessons");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81c4001f-552c-4aaa-92e7-243cb0c354b5", "AQAAAAEAACcQAAAAEEQ1FsyBqfIV0dMvv0Rh7wqh/H2du9XvbmEiX5c0iI37ND72Hy5xvZQz9Ch5b/+kfA==", "21427493-1ae5-40e3-a35e-6fb93d674751" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 905, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 905, DateTimeKind.Utc).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 905, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 907, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 905, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 905, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 7, 12, 57, 906, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Materials_MaterialId",
                table: "Lessons",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Videos_VideoId",
                table: "Lessons",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Materials_MaterialId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Videos_VideoId",
                table: "Lessons");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46da8b31-efef-4b86-873a-65aa3e763f5e", "AQAAAAEAACcQAAAAEEh2u2g9TbC3YOPrOxJ3pT4xlhfjq1eNiFhoG9/CwJK/dYnUv5UXYh1gvQAIw8Pg2A==", "045c258a-6001-4ef3-99f2-ff64aac2ca83" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 566, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Materials_MaterialId",
                table: "Lessons",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Videos_VideoId",
                table: "Lessons",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}

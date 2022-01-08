﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeDefaultAdminCredentialsAndNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2ac05c2c-b32b-41b5-adf8-05755540fb43", "REGULAR ADMINISTRATOR", "AQAAAAEAACcQAAAAENVo1QR6WNLs2fbvErAhbVZ719Lwy4OUgYAdqkrG5ljMfLrgXcwepJLqkZn3nvFiTQ==", "722187c4-4736-4c6e-b4d3-354b9836af90", "Regular Administrator" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 122, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 120, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 120, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 120, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 120, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 120, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 5, 22, 32, 121, DateTimeKind.Utc).AddTicks(4244));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "16a2f207-3312-4603-8923-cf43ff7cb60c", "USERNAME", "AQAAAAEAACcQAAAAEBIQlhd32dTvZLB8ELVqqvE2bJBIPfnX0kSvA3axM6ZFDW5+ny1dK2PQNsB/3HvsPA==", "762e2480-1aee-4440-b080-bbfb0af08680", "Username" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 246, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 244, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 244, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 244, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 244, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4530));
        }
    }
}
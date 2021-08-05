﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeDefaultAdministratorUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fed68bf-d7cf-4e15-940f-6c5a37d561d0", "AQAAAAEAACcQAAAAEBTcXEj3bmKk8u1XfXLdanZVFR6MDdsPSqs7TSalwEl6bA7eGfidDAoq0knOR28Crg==", "ed830711-9d12-46d8-b673-1e0b3d441435" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 210, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 210, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 210, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 213, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 210, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 211, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 19, 54, 29, 212, DateTimeKind.Utc).AddTicks(1615));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69f353a7-eedc-4c89-99f8-2690500cc5b9", "AQAAAAEAACcQAAAAENhhWJJtmoWGS/Fs6RJ3C1cmzGg6mn4AetI43wfzq9O7/ONipwiRTSK+Mg/18jh51Q==", "cfc6afed-4aed-4dea-807b-552261941f2a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 730, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 730, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 730, DateTimeKind.Utc).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 732, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 730, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 730, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 13, 25, 31, 731, DateTimeKind.Utc).AddTicks(4862));
        }
    }
}

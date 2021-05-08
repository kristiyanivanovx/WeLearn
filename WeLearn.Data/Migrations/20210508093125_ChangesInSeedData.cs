﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangesInSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "DateDeleted",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b632846a-481e-43f6-9223-0345dfd97820", "AQAAAAEAACcQAAAAEA3q0Dp9KGHRZsNne9ophJTae1EyAQ9+dZud8xdd1jNjJLJyvlD3o60Ky//gj6EAow==", "8ee0ec35-25bb-49eb-aa04-22d98ac44923" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 77, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 77, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 77, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 79, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 77, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Subject" },
                values: new object[] { new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(1168), "Unacceptable behaviour" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(6056));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Videos",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Reports",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Materials",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Lessons",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Comments",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "Categories",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "AspNetRoles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeleted",
                table: "AspNetRoles",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dcf3a7b-40ab-4999-987c-70009ae60e89", "AQAAAAEAACcQAAAAECLoK5b3ACHEmUpfNnoFxFFEfxFns0wlkgS4bPE2tmBUjvRnQAVxyhlHP8sknVPoBA==", "34dba80e-997e-410c-960b-fa77a91d6df9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 779, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 780, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 780, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 782, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 780, DateTimeKind.Utc).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Subject" },
                values: new object[] { new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(2693), "Swearing in comment" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "ApplicationUserId", "CommentId", "DateCreated", "DateDeleted", "Description", "IsDeleted", "LessonId", "Subject" },
                values: new object[] { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", null, new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(2251), null, "This username is unacceptable.", false, null, "Bad words in username" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 14, 14, 23, 781, DateTimeKind.Utc).AddTicks(8518));
        }
    }
}

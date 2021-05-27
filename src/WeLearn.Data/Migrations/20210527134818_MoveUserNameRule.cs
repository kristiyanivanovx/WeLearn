﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class MoveUserNameRule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "character varying(35)",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0019f772-eac5-40df-b8a2-7fd8dd02ef80", "AQAAAAEAACcQAAAAEEqHA4dTVoa8ofKNMImCUOazm7PK/pxG4OoRdzutyOIBMbVJ4sSe/7iliZIr2SdudA==", "31b8efa6-87bb-4182-8f85-abe219113d6f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 302, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 303, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 48, 17, 304, DateTimeKind.Utc).AddTicks(2248));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(35)",
                oldMaxLength: 35,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99fe48c8-db6a-450a-a094-040a403a5791", "AQAAAAEAACcQAAAAELfZ+OA3giIwsfrtVLJKAI2ZxqIsAsVvP3DNpWC13f6Ro6UJO/gC6raTIROt9YFfZw==", "45c31d4c-25e3-40c9-b594-7dc5c00e1074" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 792, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 13, 42, 35, 793, DateTimeKind.Utc).AddTicks(1664));
        }
    }
}
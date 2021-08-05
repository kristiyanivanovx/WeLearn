﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class CleanUpSignalrChatModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "ChatApplicationUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be4ebb8a-b0c4-491a-a983-98e81df9e179", "AQAAAAEAACcQAAAAEEoXBcfA91Us1t6i3Tw6CU+l59MQkMLv/So3aKcH0c7FNJiSv//t/aPRpvYRlwZ9mw==", "6d524a59-6486-466a-8d59-bdeea5cde694" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6285));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Chats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "ChatApplicationUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
    }
}

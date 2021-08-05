﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangePrivateMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserPrivateMessage");

            migrationBuilder.AddColumn<string>(
                name: "ReceiverId",
                table: "PrivateMessages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "PrivateMessages",
                type: "text",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessages_ReceiverId",
                table: "PrivateMessages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessages_SenderId",
                table: "PrivateMessages",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateMessages_AspNetUsers_ReceiverId",
                table: "PrivateMessages",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateMessages_AspNetUsers_SenderId",
                table: "PrivateMessages",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMessages_AspNetUsers_ReceiverId",
                table: "PrivateMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMessages_AspNetUsers_SenderId",
                table: "PrivateMessages");

            migrationBuilder.DropIndex(
                name: "IX_PrivateMessages_ReceiverId",
                table: "PrivateMessages");

            migrationBuilder.DropIndex(
                name: "IX_PrivateMessages_SenderId",
                table: "PrivateMessages");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "PrivateMessages");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "PrivateMessages");

            migrationBuilder.CreateTable(
                name: "ApplicationUserPrivateMessage",
                columns: table => new
                {
                    ParticipantsId = table.Column<string>(type: "text", nullable: false),
                    PrivateMessagesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserPrivateMessage", x => new { x.ParticipantsId, x.PrivateMessagesId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserPrivateMessage_AspNetUsers_ParticipantsId",
                        column: x => x.ParticipantsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserPrivateMessage_PrivateMessages_PrivateMessag~",
                        column: x => x.PrivateMessagesId,
                        principalTable: "PrivateMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cca01f76-31a1-4067-b43e-b841142441a6", "AQAAAAEAACcQAAAAECFTcI8E6d4cxtQF56U+BbBVAdgCl724HRgjqku0LYePi/DtBmsv01QrqLjDgcTA5g==", "58f6503a-2737-49a6-96d9-7ee050fbad8e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 930, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 930, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 930, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 933, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 930, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 930, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 4, 12, 14, 50, 931, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserPrivateMessage_PrivateMessagesId",
                table: "ApplicationUserPrivateMessage",
                column: "PrivateMessagesId");
        }
    }
}

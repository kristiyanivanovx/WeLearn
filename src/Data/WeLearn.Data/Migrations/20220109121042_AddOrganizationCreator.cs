using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddOrganizationCreator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatorId",
                table: "Organizations",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b3fa86b1-21fe-41f2-8da0-d3738b027560", "REGULARADMIN", "AQAAAAEAACcQAAAAEN765bW7AWffZVPLU8mU9yvIdWQEcscF5nGhs2UYceaIO+pckwKSw/xQTzBFWFw8zw==", "aae92287-9e49-42e5-b5cc-4b2287400aeb", "RegularAdmin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 420, DateTimeKind.Utc).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 418, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 418, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 418, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 418, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 418, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 9, 12, 10, 40, 419, DateTimeKind.Utc).AddTicks(3108));

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_CreatorId",
                table: "Organizations",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_AspNetUsers_CreatorId",
                table: "Organizations",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_AspNetUsers_CreatorId",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_CreatorId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Organizations");

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
    }
}

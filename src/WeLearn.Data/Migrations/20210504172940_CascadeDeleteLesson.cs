using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class CascadeDeleteLesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_AspNetUsers_ApplicationUserId",
                table: "Lessons");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d835f65-18b9-4f45-b45d-718f750a04b6", "AQAAAAEAACcQAAAAEDdb0lLwe5VMtgsNTE3OR0TwQYHqjlZKZACZYmjsES8OfuhCCFDwpffnhz23TOatqw==", "a8b74ab8-8e1f-4a94-9d70-25507dbb8ead" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 36, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 29, 40, 37, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_AspNetUsers_ApplicationUserId",
                table: "Lessons",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_AspNetUsers_ApplicationUserId",
                table: "Lessons");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46c8292e-a8fe-49cf-9264-bb063d230d78", "AQAAAAEAACcQAAAAEJf1OkphpjMYXHCjB3ea5bpRNuEgtf8Bkx6lUpGqJR+V5dIgBJaSaxZduOhFYxwJ+w==", "68a715ed-6666-43c0-b359-b8e3962882fe" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 900, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 12, 10, 55, 901, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_AspNetUsers_ApplicationUserId",
                table: "Lessons",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}

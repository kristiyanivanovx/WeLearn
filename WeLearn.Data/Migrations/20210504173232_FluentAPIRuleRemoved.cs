using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class FluentAPIRuleRemoved : Migration
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
                values: new object[] { "b0bc5f7e-aab2-47df-b89b-f6ecfa4d2626", "AQAAAAEAACcQAAAAELvBQ0wJw5Vy2RLZcsC+Lkv4VcOgN5iDTekbET1AQjZL77Yln/SKyPgxQvNVSEXeuw==", "2a594a73-47ee-41b1-9462-422cfaeed6d3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 215, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 213, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 4, 17, 32, 31, 214, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_AspNetUsers_ApplicationUserId",
                table: "Lessons",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class IncreaseMessageMaxLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Messages",
                type: "character varying(1500)",
                maxLength: 1500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b05a821-c999-44be-bf5c-dfe9d0f431fa", "AQAAAAEAACcQAAAAED+gnpa8oOFcbVQ+7Gbe25Fb9XvDOTlT1I/KZltPhRDFArPe3B7j0DhBwQdqA5F9UA==", "e769a656-4100-4515-b0e6-017287542d1d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 826, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 23, 32, 31, 825, DateTimeKind.Utc).AddTicks(6807));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Messages",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(1500)",
                oldMaxLength: 1500);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a174a642-94bb-4182-aca5-bd18caf56658", "AQAAAAEAACcQAAAAEE+Y+nlQL501ZcgY1jAv6AVRtmAYzBJT6QnH3wJiYtnuIRyGNi6+SGlz079rWmoA1A==", "ebaec100-c046-4ba9-899e-5e6e22258f13" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 746, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 746, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 746, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 748, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 12, 18, 16, 35, 747, DateTimeKind.Utc).AddTicks(7367));
        }
    }
}

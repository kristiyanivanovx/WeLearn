using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddDateCreatedToChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4555a5a5-5619-4d84-82fc-de406748ef55", "AQAAAAEAACcQAAAAELNn3Rm1vb9ibxPzKxqfgq/bTbzGfUAslhDcwELgheKomdXF0Kwv67i79o30Su7E9A==", "4ce74d8a-39d5-44c4-87aa-c8603d8c2428" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 626, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 628, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 46, 38, 627, DateTimeKind.Utc).AddTicks(9180));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6e69d31-ebdb-41b5-b80e-d6f0c65e73a9", "AQAAAAEAACcQAAAAEFyRxZaysD6yCIw9aOZMfrJ16JCcimo2H3xaLm5qMQFrcHspA/9VjVj0yy8ZO9u+DQ==", "7d25dfac-00cf-4099-ac1a-76ebe2e6f1d3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 929, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 929, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 929, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 932, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 929, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 930, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 44, 18, 931, DateTimeKind.Utc).AddTicks(2706));
        }
    }
}

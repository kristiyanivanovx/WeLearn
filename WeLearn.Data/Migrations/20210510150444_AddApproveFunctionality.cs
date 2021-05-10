using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddApproveFunctionality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Lessons",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021efabf-2ca8-4f0c-ab3d-2bba8876c7b0", "AQAAAAEAACcQAAAAELdOrX8rP+jKR1TpMEinqn7COS0UAkBH6dUcNCcIJX2Jy2qAmU55pWMR5jVT3jLfkQ==", "8547212a-a169-4ef4-9efb-5567431bee29" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 940, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 942, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 4, 42, 941, DateTimeKind.Utc).AddTicks(8423));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Lessons");

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
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 9, 31, 24, 78, DateTimeKind.Utc).AddTicks(1168));

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
    }
}

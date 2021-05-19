using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddAppUserIdToReportSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5afc2577-686b-4b03-bc94-2f2bc67bfde5", "AQAAAAEAACcQAAAAEP+4JGdwaVnOeI3o1rS3Z6u4kzrA3PGjKCOUrOjc6JEvSuyfwcbExzbXOmCevDzjuA==", "e7bc94dc-bf9f-40a4-9857-34103cad893f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 42, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 42, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 42, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 42, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "DateCreated" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 5, 11, 12, 44, 11, 42, DateTimeKind.Utc).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "DateCreated" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", new DateTime(2021, 5, 11, 12, 44, 11, 42, DateTimeKind.Utc).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(2286));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ace6ef3-2dfd-4b9b-9506-5f4b990ec266", "AQAAAAEAACcQAAAAEGZGSa0DvjgfctxCYLQj0k+d2O5/Fjy25MVSLNbqcM+K7IO8vSkL8zyOj4axW6U+0Q==", "e2296685-8137-4a62-bf1d-b5f29898d25f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 38, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 38, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 38, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 40, DateTimeKind.Utc).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "DateCreated" },
                values: new object[] { null, new DateTime(2021, 5, 10, 15, 15, 45, 38, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "DateCreated" },
                values: new object[] { null, new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(5979));
        }
    }
}

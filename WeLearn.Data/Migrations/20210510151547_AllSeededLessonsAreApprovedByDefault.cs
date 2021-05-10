using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AllSeededLessonsAreApprovedByDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(8397), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9410), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9417), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9419), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9421), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9423), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9427), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9429), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9431), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9433), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9435), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9438), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9441), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9443), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9445), true });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(9447), true });

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
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 38, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 15, 45, 39, DateTimeKind.Utc).AddTicks(1213));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e616094-80d9-42fc-bd71-7b45bebce02c", "AQAAAAEAACcQAAAAEJzrjb98x+OFJtz6V7yZvcJ1XdOjRrOr8NrRbwjjEYf7wR6H4BcGNE0RSJ4rzpkt4A==", "90cc8be2-23b8-4db0-8fff-a6c68b552708" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 767, DateTimeKind.Utc).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 767, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 767, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(4772), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5566), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5570), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5572), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5575), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5660), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5663), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5665), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5669), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5671), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5674), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5677), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5681), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5683), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5686), false });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "IsApproved" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(5689), false });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 767, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 767, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 15, 6, 4, 768, DateTimeKind.Utc).AddTicks(3085));
        }
    }
}

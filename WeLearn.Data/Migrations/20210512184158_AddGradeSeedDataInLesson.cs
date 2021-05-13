using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddGradeSeedDataInLesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20aa4f5a-0bf2-47cf-bab3-2a4ecc4092f6", "AQAAAAEAACcQAAAAEJigdXzWGGGQ+wFBUTfOv93WsVDxFsBUBy06qFVyY8EcECoX8Ht1O3H12ZTKLzEwRg==", "3ada309f-e623-45b7-8547-61efbda6fca9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7198), 1 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7927), 2 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7932), 3 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7934), 4 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7936), 5 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7937), 6 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7939), 7 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7941), 8 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7943), 9 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7944), 10 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7946), 11 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7948), 12 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7951), 5 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7953), 1 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(7954), 2 });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 12, 18, 41, 58, 14, DateTimeKind.Utc).AddTicks(5693));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(4353), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5322), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5329), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5331), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5332), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5334), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5336), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5338), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5340), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5341), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5343), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5346), 0 });

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
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5351), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5353), 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Grade" },
                values: new object[] { new DateTime(2021, 5, 11, 12, 44, 11, 43, DateTimeKind.Utc).AddTicks(5354), 0 });

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
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 42, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 12, 44, 11, 42, DateTimeKind.Utc).AddTicks(8055));

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
    }
}

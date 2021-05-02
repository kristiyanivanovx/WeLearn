using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangesInConnectionString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d2c348c-1425-4c9d-8e32-8bddb43a356c", "AQAAAAEAACcQAAAAELzZa3VYwx9LQP706k0b30Neg+gp19cXcV3r4Q7+LsO7C4ht5FVmm6pXCAsUBATYMQ==", "6820c8a5-51a2-4304-910f-669b2e484ae8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 749, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 751, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 13, 52, 11, 750, DateTimeKind.Utc).AddTicks(8950));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4daacaf0-f4a7-4624-a83f-8edc031f734b", "AQAAAAEAACcQAAAAEDz1vSG3PnQXFplgwaNNV/NfcDVH0HsBLqSNkIXkMvrBn1eJ73ZjoAoZZeK8VoCDjg==", "397b2afa-d7a6-4e14-af75-ffa9737cc7a6" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 616, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 617, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 617, DateTimeKind.Utc).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 619, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 617, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 617, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 617, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 12, 18, 25, 618, DateTimeKind.Utc).AddTicks(3699));
        }
    }
}

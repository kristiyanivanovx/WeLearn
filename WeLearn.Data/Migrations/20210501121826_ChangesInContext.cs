using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangesInContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "191870a5-1c40-4b6a-a157-6067148459ac", "AQAAAAEAACcQAAAAEDmyUgqrzs1qrVXP3yEbRc3zkRgcTRHaqOhuczoH61k2/NOQAMA9B/1Mvv/MHMgH1Q==", "d67b3659-3886-40af-85fd-78ec77718d82" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 869, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 869, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 869, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 871, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 11, 34, 42, 870, DateTimeKind.Utc).AddTicks(6545));
        }
    }
}

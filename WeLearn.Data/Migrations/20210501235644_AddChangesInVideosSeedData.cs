using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddChangesInVideosSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae1d970f-304d-428d-8c8c-b7927e87f40a", "AQAAAAEAACcQAAAAEFsPAQ0HyLcQNB+8I9DpLiuPGu/Y4/VuD19eiAA6EFjlJUoKFdK3atv9eQLJdCdINw==", "edf212d4-f29b-4f6b-9f4b-2b5c299bfea4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 863, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 863, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 863, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 865, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(6089), "/uploads/videos/modal-verbs.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 23, 56, 42, 864, DateTimeKind.Utc).AddTicks(7388));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26a76044-38ea-4ed2-9b70-622167599c44", "AQAAAAEAACcQAAAAEChRhKRLkVdcmRLDVA5+K7O5qzErWtJ2/0s4cGkWC6gTs3ji+T6GMoV2BWip98K51w==", "aa0e28c9-8039-4f12-a92e-e03a0eae3f23" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 281, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 281, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 281, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 281, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 281, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 281, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Link" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(6207), "/uploads/videos/teaching1.mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7939));
        }
    }
}

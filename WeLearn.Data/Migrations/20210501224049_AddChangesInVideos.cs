using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddChangesInVideos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoContentType",
                table: "Videos",
                type: "text",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "DateCreated", "Description", "PostName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2975), "Eastern European Countries. Their iconomic growth and political stances. Ukraine.", "Ukraine, Eastern Europe" });

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
                columns: new[] { "DateCreated", "Description", "PostName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 283, DateTimeKind.Utc).AddTicks(2989), "A brief peek into our ancestors' life.", "Peek in the past" });

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
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(6207), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7911), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7917), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7919), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7921), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7923), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7925), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7926), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7928), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7929), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7931), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7932), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7934), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7936), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7937), "video/mp4" });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                columns: new[] { "DateCreated", "VideoContentType" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 40, 48, 282, DateTimeKind.Utc).AddTicks(7939), "video/mp4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoContentType",
                table: "Videos");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efd159b7-726c-43f1-95bd-b146dfccd7cd", "AQAAAAEAACcQAAAAEOHz1KH/2UGGO2uxI2PcMeIbjz6mCY2djgBI4NJ/pp+E1P1Bb79jlR6CEDRU6AWn0Q==", "5fbd32e3-ca84-4236-8f26-c011d2ff7d6a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 957, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "DateCreated", "Description", "PostName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2548), "Eastern European Countries. Their iconomic growth and political stances. Bulgaria.", "Bulgaria, Eastern Europe" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 11,
                columns: new[] { "DateCreated", "Description", "PostName" },
                values: new object[] { new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2560), "A lesson about the First Bulgarian Empire, founded 681 in Pliska.", "First Bulgarian Empire Part I" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 959, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 1, 22, 12, 43, 958, DateTimeKind.Utc).AddTicks(9243));
        }
    }
}

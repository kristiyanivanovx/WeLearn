using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class FixEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Materials_MaterialId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Videos_VideoId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_MaterialId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_VideoId",
                table: "Lessons");

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "Videos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "Videos",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "Materials",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "Materials",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46da8b31-efef-4b86-873a-65aa3e763f5e", "AQAAAAEAACcQAAAAEEh2u2g9TbC3YOPrOxJ3pT4xlhfjq1eNiFhoG9/CwJK/dYnUv5UXYh1gvQAIw8Pg2A==", "045c258a-6001-4ef3-99f2-ff64aac2ca83" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 566, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 568, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 6, 25, 21, 567, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_MaterialId",
                table: "Lessons",
                column: "MaterialId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_VideoId",
                table: "Lessons",
                column: "VideoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Materials_MaterialId",
                table: "Lessons",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Videos_VideoId",
                table: "Lessons",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Materials_MaterialId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Videos_VideoId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_MaterialId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_VideoId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "LessonId",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "LessonId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Materials");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c447a0d-c65b-419d-9245-33238116704d", "AQAAAAEAACcQAAAAECjb/Lf2bYJ4kt8ui4Qo7Te+czoMlKjtyVv+giVZZbDETbqxAu1Z3jCYLzK8gFJOow==", "a0b34105-6274-4f62-8059-e952e4e25db5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 500, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 10, 48, 44, 501, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_MaterialId",
                table: "Lessons",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_VideoId",
                table: "Lessons",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Materials_MaterialId",
                table: "Lessons",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Videos_VideoId",
                table: "Lessons",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

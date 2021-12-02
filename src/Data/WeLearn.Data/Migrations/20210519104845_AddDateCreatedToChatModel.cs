using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddDateCreatedToChatModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Chats",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Chats");

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
    }
}

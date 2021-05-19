using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangesInData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ec701d9-7f54-4479-a9be-ecd4f4ff8cdf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateModified", "Name", "NormalizedName" },
                values: new object[] { "8bb1c4d6-0f1c-48e5-8738-986d1fbb0bdf", "4e5320fc-4c58-4e7c-9b19-edee79af6c1b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5d18595-cda9-4a32-87d2-ee0e25350bd3", "AQAAAAEAACcQAAAAEGoGIQokSQPf5CQEuNYVudzbXEOnEZ+2fVvjaEPBt++1LqTsUeYKJtwSk5CxB51/1g==", "316f7d80-3ecd-4e82-9a70-58f08b8d8c0f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 997, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 998, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 38, 44, 999, DateTimeKind.Utc).AddTicks(5));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bb1c4d6-0f1c-48e5-8738-986d1fbb0bdf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateModified", "Name", "NormalizedName" },
                values: new object[] { "4ec701d9-7f54-4479-a9be-ecd4f4ff8cdf", "519c380d-8844-4451-a14d-44caf54ee694", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abe5673c-0b92-4e9e-8d1f-2f6f4be159d3", "AQAAAAEAACcQAAAAEEJ6pluUMGsYKxxh9+DpSsPJt1zP57TfCeFxLPBPme7Y79JdNnuINwUW8jToQtdYxQ==", "799daa61-4e52-4f4e-a019-bec04816e073" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 1, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 5, 3, 21, 30, 16, 2, DateTimeKind.Utc).AddTicks(2397));
        }
    }
}

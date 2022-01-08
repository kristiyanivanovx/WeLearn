using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ConfigureOnDeleteForOrganizations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserOrganization");

            migrationBuilder.CreateTable(
                name: "OrganizationApplicationUser",
                columns: table => new
                {
                    ApplicationUsersId = table.Column<string>(type: "text", nullable: false),
                    OrganizationsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationApplicationUser", x => new { x.ApplicationUsersId, x.OrganizationsId });
                    table.ForeignKey(
                        name: "FK_OrganizationApplicationUser_AspNetUsers_ApplicationUsersId",
                        column: x => x.ApplicationUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationApplicationUser_Organizations_OrganizationsId",
                        column: x => x.OrganizationsId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16a2f207-3312-4603-8923-cf43ff7cb60c", "AQAAAAEAACcQAAAAEBIQlhd32dTvZLB8ELVqqvE2bJBIPfnX0kSvA3axM6ZFDW5+ny1dK2PQNsB/3HvsPA==", "762e2480-1aee-4440-b080-bbfb0af08680" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 246, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 244, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 244, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 244, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 244, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 8, 4, 52, 29, 245, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationApplicationUser_OrganizationsId",
                table: "OrganizationApplicationUser",
                column: "OrganizationsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationApplicationUser");

            migrationBuilder.CreateTable(
                name: "ApplicationUserOrganization",
                columns: table => new
                {
                    ApplicationUsersId = table.Column<string>(type: "text", nullable: false),
                    OrganizationsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserOrganization", x => new { x.ApplicationUsersId, x.OrganizationsId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserOrganization_AspNetUsers_ApplicationUsersId",
                        column: x => x.ApplicationUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationUserOrganization_Organizations_OrganizationsId",
                        column: x => x.OrganizationsId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c375e322-601e-421e-8843-7d40ad9a2443", "AQAAAAEAACcQAAAAEJ4kIpqauGqiFXGT3mt8O+12bQuw51U1z4+OCsRssxDfp1vTmcufVRyoSUpGQjk4NQ==", "ce1ac582-e0cc-4cc7-b137-a11e9c03e5c3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 391, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 7, 20, 35, 36, 390, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserOrganization_OrganizationsId",
                table: "ApplicationUserOrganization",
                column: "OrganizationsId");
        }
    }
}

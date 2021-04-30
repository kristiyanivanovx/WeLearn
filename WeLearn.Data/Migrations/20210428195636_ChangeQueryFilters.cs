using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeQueryFilters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Reports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af7d6864-180c-40d4-8551-d6c5316fba04", "AQAAAAEAACcQAAAAEPZAFFlctXKnf88TFriP/bfgRH0xhhmAU9A/K2eSlNMdcZmpQpvcsMXap4EMPO1dCQ==", "63a46992-3f34-44a6-940f-6fe2057472ae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Reports");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3b86fef-09c3-4a3c-88b0-40c896d8a033", "AQAAAAEAACcQAAAAECs2o80bmFuJVP+EsbWeLHivopu1KC7XcPW5R6D0P2GmbfMIwHsdRCChF5eFsiiadg==", "3b15ff92-d7e9-4990-8282-4b8f871663fe" });
        }
    }
}

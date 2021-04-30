using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddIsDeletedBoolean : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f527e90a-be09-4687-868a-36b981e756a4", "AQAAAAEAACcQAAAAENiS79oYXwcDanHQuo6R9YddUNBz86NufXmaCMzUpcbbfwsEQ4cmPhkpNzU9eAbz6Q==", "e395fca9-a4c5-46a8-a27d-f3df75635d58" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eb28872-24b4-4476-9b8c-5336af6279ca", "AQAAAAEAACcQAAAAEBw3QENAUXpy5SWE3X85tH+22zTkOoC+RXJWLgd45LWsJFZBQjnSmDV47QVk19alQQ==", "02da4608-03bd-48bf-bf36-f4c0b6247c40" });
        }
    }
}

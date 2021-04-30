using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddIsResolvedDefaultValueInReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1ed44b8-e7cc-463f-a20b-f0e2a9849dd8", "AQAAAAEAACcQAAAAEItcTSk89RhbIMgxPjPx507lmBHZhatsl2Os0cZdz0G+zTmOIOBns5ndZsycx96sJg==", "b3245868-ae69-4505-9d31-666326b80a64" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f527e90a-be09-4687-868a-36b981e756a4", "AQAAAAEAACcQAAAAENiS79oYXwcDanHQuo6R9YddUNBz86NufXmaCMzUpcbbfwsEQ4cmPhkpNzU9eAbz6Q==", "e395fca9-a4c5-46a8-a27d-f3df75635d58" });
        }
    }
}

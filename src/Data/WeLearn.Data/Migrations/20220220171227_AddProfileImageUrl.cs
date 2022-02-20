using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddProfileImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileImageUrl",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "720fc008-fb4c-4deb-adc1-25ff7f33de99", "AQAAAAEAACcQAAAAEOjxug7gj8XfE6g7eOG7kZGz6StFxHVmZJ/dKtIOQ10gPIsmrBnJMcyyfU7LRhkoXA==", "536c12ec-da95-449f-9408-37b13d60110c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImageUrl",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14f488d5-8a76-48df-8811-fdf8600ae321", "AQAAAAEAACcQAAAAEGx6IBi4tmT8LSqtNrMz92XfrzyrRYhNKoQwmdpbdeq04YrbMSOCBYgmVJ+vV5HbSw==", "30c9832b-e5e8-44e6-998c-73158dbec3e7" });
        }
    }
}

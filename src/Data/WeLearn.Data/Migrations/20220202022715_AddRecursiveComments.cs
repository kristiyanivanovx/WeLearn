using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddRecursiveComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Comments",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14f488d5-8a76-48df-8811-fdf8600ae321", "AQAAAAEAACcQAAAAEGx6IBi4tmT8LSqtNrMz92XfrzyrRYhNKoQwmdpbdeq04YrbMSOCBYgmVJ+vV5HbSw==", "30c9832b-e5e8-44e6-998c-73158dbec3e7" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentId",
                table: "Comments",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_ParentId",
                table: "Comments",
                column: "ParentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_ParentId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ParentId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96a1e9d4-058d-4eb4-8164-7c5d358eba47", "AQAAAAEAACcQAAAAEHn4DEHWdm6RHbIg8cGxm7IbWYLVv6+X8DBu82Kr4UBsEfbn45UMe2DdnzVYqoIxcQ==", "80b3db43-198c-47a0-92a8-80bc3fa46fb5" });
        }
    }
}

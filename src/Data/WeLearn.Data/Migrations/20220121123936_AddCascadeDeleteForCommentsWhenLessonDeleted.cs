using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddCascadeDeleteForCommentsWhenLessonDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e63acf2-433f-4faa-8d0d-d99ad71e2917", "AQAAAAEAACcQAAAAEKcNRh5880T56zY127+KgniUrzq7ClTjTgPiiA+5WFuWCB/UJLSC2620UrJbowcNHQ==", "2ca32756-3ec5-49cd-83b8-d0b4db89889a" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d9a90b8-d830-409a-a5b5-eec535173bca", "AQAAAAEAACcQAAAAEF5Wh4ExXdnlXEu0dg9kO810xGWlGajWmmxYe+1i9V4q+nxU0sBmOCYNNRKLfH0vzw==", "4f066e71-b2b5-4d07-857e-6e43fa9efbdb" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

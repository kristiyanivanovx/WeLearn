using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddLessonForeignKeyLikeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Lessons_LessonId",
                table: "Likes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8658cd0-06f2-4009-b2ff-613fd5d51dd7", "AQAAAAEAACcQAAAAEMeMxGJjQM1giJ4mMsIZms5j78qZ8yO9q257lanCbdXbR2e2VUAli3dw29h91tfvsg==", "3b9c80fb-041b-40f1-bdca-5861087572a6" });

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Lessons_LessonId",
                table: "Likes",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Lessons_LessonId",
                table: "Likes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c382f3e-fb2c-4a57-b193-d1b36d2d8c36", "AQAAAAEAACcQAAAAEC1i87sumikIrfCjiMsf+vkYmKAuHWTC7hfkWk39tz5n6rhdTbcawXIOugjKdiwfBw==", "9f9bc53a-cc2c-49e8-8a7b-4bca41138fa7" });

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Lessons_LessonId",
                table: "Likes",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

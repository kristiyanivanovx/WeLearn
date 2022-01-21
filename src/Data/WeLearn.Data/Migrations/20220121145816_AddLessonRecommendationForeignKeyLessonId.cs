using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddLessonRecommendationForeignKeyLessonId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Lessons_LessonId",
                table: "Recommendations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa4b1bd1-e697-4d5f-818c-c092d1fd7c5e", "AQAAAAEAACcQAAAAELxzc4e+d38k7dl4x1HMvMXXRoYlCz/fmPysKym0rgC4qIpXEZbugvB4niUEo0VzbQ==", "15194a29-4157-4961-88c8-9810b5194d43" });

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Lessons_LessonId",
                table: "Recommendations",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Lessons_LessonId",
                table: "Recommendations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66c5b862-eb2a-4ff0-976b-c2a675e347de", "AQAAAAEAACcQAAAAELWHU/E6pgoRGtX9gSDZNvKxUyQiKMophO8ZCDFIYQEgGNSo1rUgV+1tqrCo+pCkXg==", "76cbef13-b272-4729-b684-63e4c15f867f" });

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Lessons_LessonId",
                table: "Recommendations",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

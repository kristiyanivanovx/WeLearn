using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddRecommendationForeignKeyLessonId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66c5b862-eb2a-4ff0-976b-c2a675e347de", "AQAAAAEAACcQAAAAELWHU/E6pgoRGtX9gSDZNvKxUyQiKMophO8ZCDFIYQEgGNSo1rUgV+1tqrCo+pCkXg==", "76cbef13-b272-4729-b684-63e4c15f867f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8658cd0-06f2-4009-b2ff-613fd5d51dd7", "AQAAAAEAACcQAAAAEMeMxGJjQM1giJ4mMsIZms5j78qZ8yO9q257lanCbdXbR2e2VUAli3dw29h91tfvsg==", "3b9c80fb-041b-40f1-bdca-5861087572a6" });
        }
    }
}

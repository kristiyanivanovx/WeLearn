using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddUserSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44ab4cef-61bd-445b-ac87-4ae151b33962", "AQAAAAEAACcQAAAAEKMHq6+2MjqxTmNsjzqHktfnq9PFgPkXAdHki3egi/npfVXg9/f/yiDIhA0jaNIZRA==", "c6c3c3c7-ce69-4b48-acee-d0dbfe46e717" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa4b1bd1-e697-4d5f-818c-c092d1fd7c5e", "AQAAAAEAACcQAAAAELxzc4e+d38k7dl4x1HMvMXXRoYlCz/fmPysKym0rgC4qIpXEZbugvB4niUEo0VzbQ==", "15194a29-4157-4961-88c8-9810b5194d43" });
        }
    }
}

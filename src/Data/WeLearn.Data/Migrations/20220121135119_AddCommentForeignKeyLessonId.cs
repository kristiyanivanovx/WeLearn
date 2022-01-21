using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddCommentForeignKeyLessonId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7924ac16-0983-4113-b27f-33d2f27ee59a", "AQAAAAEAACcQAAAAEHLvbxLBDtAK3v+MIABbjSA2Xp1Lizf92el8oEIrDA6IqgbNEW+C3E62EVBtJOwQ7A==", "c6bdd16e-aef8-4a91-8d07-a47a64bbba61" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e63acf2-433f-4faa-8d0d-d99ad71e2917", "AQAAAAEAACcQAAAAEKcNRh5880T56zY127+KgniUrzq7ClTjTgPiiA+5WFuWCB/UJLSC2620UrJbowcNHQ==", "2ca32756-3ec5-49cd-83b8-d0b4db89889a" });
        }
    }
}

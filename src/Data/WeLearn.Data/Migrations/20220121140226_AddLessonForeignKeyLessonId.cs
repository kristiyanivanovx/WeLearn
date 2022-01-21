using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddLessonForeignKeyLessonId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c382f3e-fb2c-4a57-b193-d1b36d2d8c36", "AQAAAAEAACcQAAAAEC1i87sumikIrfCjiMsf+vkYmKAuHWTC7hfkWk39tz5n6rhdTbcawXIOugjKdiwfBw==", "9f9bc53a-cc2c-49e8-8a7b-4bca41138fa7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d91316c6-8823-4614-a3c5-6228f06c746a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7924ac16-0983-4113-b27f-33d2f27ee59a", "AQAAAAEAACcQAAAAEHLvbxLBDtAK3v+MIABbjSA2Xp1Lizf92el8oEIrDA6IqgbNEW+C3E62EVBtJOwQ7A==", "c6bdd16e-aef8-4a91-8d07-a47a64bbba61" });
        }
    }
}

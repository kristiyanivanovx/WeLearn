using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class ChangeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3b86fef-09c3-4a3c-88b0-40c896d8a033", "AQAAAAEAACcQAAAAECs2o80bmFuJVP+EsbWeLHivopu1KC7XcPW5R6D0P2GmbfMIwHsdRCChF5eFsiiadg==", "3b15ff92-d7e9-4990-8282-4b8f871663fe" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Content",
                value: "I like it!");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Content",
                value: "Good, but can be imroved.");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Content",
                value: "This is very nice.");

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                columns: new[] { "Description", "Subject" },
                values: new object[] { "Bad language in lesson's title.", "The language used in title" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                columns: new[] { "Description", "Subject" },
                values: new object[] { "Tjhis username is unacceptable.", "Bad words in username" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                columns: new[] { "Description", "Subject" },
                values: new object[] { "Bad language in comment.", "Swearing in comment" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1ed44b8-e7cc-463f-a20b-f0e2a9849dd8", "AQAAAAEAACcQAAAAEItcTSk89RhbIMgxPjPx507lmBHZhatsl2Os0cZdz0G+zTmOIOBns5ndZsycx96sJg==", "b3245868-ae69-4505-9d31-666326b80a64" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Content",
                value: "i like it!");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Content",
                value: "can be imroved");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Content",
                value: "very good");

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1,
                columns: new[] { "Description", "Subject" },
                values: new object[] { "Bad language in title", "02174cf0–9412–4cfe-afbf-59f706d72cf6" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2,
                columns: new[] { "Description", "Subject" },
                values: new object[] { "Bad words in username", "02174cf0–9412–4cfe-afbf-59f706d72cf6" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3,
                columns: new[] { "Description", "Subject" },
                values: new object[] { "Bad language in comment", "02174cf0–9412–4cfe-afbf-59f706d72cf6" });
        }
    }
}

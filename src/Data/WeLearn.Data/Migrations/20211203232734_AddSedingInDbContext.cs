using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddSedingInDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatApplicationUsers_Chats_ChatId",
                table: "ChatApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Categories_CategoryId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMessages_AspNetUsers_ReceiverId",
                table: "PrivateMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMessages_AspNetUsers_SenderId",
                table: "PrivateMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrivateMessages",
                table: "PrivateMessages");

            migrationBuilder.RenameTable(
                name: "PrivateMessages",
                newName: "PrivateMessage");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Videos",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Reports",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Messages",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Materials",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Lessons",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Comments",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Chats",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Categories",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "PrivateMessage",
                newName: "CreatedOn");

            migrationBuilder.RenameIndex(
                name: "IX_PrivateMessages_SenderId",
                table: "PrivateMessage",
                newName: "IX_PrivateMessage_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_PrivateMessages_ReceiverId",
                table: "PrivateMessage",
                newName: "IX_PrivateMessage_ReceiverId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Videos",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Videos",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Reports",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Reports",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Messages",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Materials",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Materials",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Lessons",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Lessons",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Comments",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Comments",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Chats",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Categories",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Categories",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetUserRoles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetUserLogins",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetUserClaims",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetRoles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "AspNetRoles",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetRoles",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "AspNetRoles",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "PrivateMessage",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PrivateMessage",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "PrivateMessage",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrivateMessage",
                table: "PrivateMessage",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c0cd420-baad-4e0b-a3cc-7e0e2730fdac", "AQAAAAEAACcQAAAAEK13/BbamUPJwtep9JgTHQw1yLOUaGKFg0gxuCPoWwy83BYIAnSXFMcocM8eNaoq2w==", "ea1a753c-076c-4c6a-867b-68001c7b3194" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Description" },
                values: new object[] { new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9063), "Eastern European Countries. Their economic growth and political stances. Ukraine." });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "Description", "Name" },
                values: new object[] { new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9065), "A peek into Shakespeare's art.", "William Shakespeare's 106 sonnet" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "Description" },
                values: new object[] { new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9072), "A lesson about acids, they effects on the environment and usage cases." });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 535, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 3, 23, 27, 33, 534, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.CreateIndex(
                name: "IX_Videos_IsDeleted",
                table: "Videos",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_IsDeleted",
                table: "Reports",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_IsDeleted",
                table: "Materials",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_IsDeleted",
                table: "Lessons",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_IsDeleted",
                table: "Comments",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IsDeleted",
                table: "Categories",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IsDeleted",
                table: "AspNetUsers",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ApplicationUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_ApplicationUserId",
                table: "AspNetUserLogins",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_ApplicationUserId",
                table: "AspNetUserClaims",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_IsDeleted",
                table: "AspNetRoles",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessage_IsDeleted",
                table: "PrivateMessage",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_ApplicationUserId",
                table: "AspNetUserClaims",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_ApplicationUserId",
                table: "AspNetUserLogins",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatApplicationUsers_Chats_ChatId",
                table: "ChatApplicationUsers",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Categories_CategoryId",
                table: "Lessons",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateMessage_AspNetUsers_ReceiverId",
                table: "PrivateMessage",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateMessage_AspNetUsers_SenderId",
                table: "PrivateMessage",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_ApplicationUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_ApplicationUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatApplicationUsers_Chats_ChatId",
                table: "ChatApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Categories_CategoryId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMessage_AspNetUsers_ReceiverId",
                table: "PrivateMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMessage_AspNetUsers_SenderId",
                table: "PrivateMessage");

            migrationBuilder.DropIndex(
                name: "IX_Videos_IsDeleted",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Reports_IsDeleted",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Materials_IsDeleted",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_IsDeleted",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Comments_IsDeleted",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Categories_IsDeleted",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_ApplicationUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_ApplicationUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_IsDeleted",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrivateMessage",
                table: "PrivateMessage");

            migrationBuilder.DropIndex(
                name: "IX_PrivateMessage_IsDeleted",
                table: "PrivateMessage");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "PrivateMessage");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PrivateMessage");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "PrivateMessage");

            migrationBuilder.RenameTable(
                name: "PrivateMessage",
                newName: "PrivateMessages");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Videos",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Reports",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Messages",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Materials",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Lessons",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Comments",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Chats",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Categories",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "PrivateMessages",
                newName: "DateCreated");

            migrationBuilder.RenameIndex(
                name: "IX_PrivateMessage_SenderId",
                table: "PrivateMessages",
                newName: "IX_PrivateMessages_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_PrivateMessage_ReceiverId",
                table: "PrivateMessages",
                newName: "IX_PrivateMessages_ReceiverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrivateMessages",
                table: "PrivateMessages",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be4ebb8a-b0c4-491a-a983-98e81df9e179", "AQAAAAEAACcQAAAAEEoXBcfA91Us1t6i3Tw6CU+l59MQkMLv/So3aKcH0c7FNJiSv//t/aPRpvYRlwZ9mw==", "6d524a59-6486-466a-8d59-bdeea5cde694" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Description" },
                values: new object[] { new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(665), "Eastern European Countries. Their iconomic growth and political stances. Ukraine." });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Description", "Name" },
                values: new object[] { new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(668), "A peek into Shakespere's art.", "William Shakespere's 106 sonnet" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Description" },
                values: new object[] { new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(682), "A lesson about acids, they effects on the environtment and usage cases." });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatApplicationUsers_Chats_ChatId",
                table: "ChatApplicationUsers",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Categories_CategoryId",
                table: "Lessons",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateMessages_AspNetUsers_ReceiverId",
                table: "PrivateMessages",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateMessages_AspNetUsers_SenderId",
                table: "PrivateMessages",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

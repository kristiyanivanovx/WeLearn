using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeLearn.Data.Migrations
{
    public partial class AddAuditInfoProperties : Migration
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
                name: "FK_ChatApplicationUsers_AspNetUsers_ApplicationUserId",
                table: "ChatApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatApplicationUsers_Chats_ChatId",
                table: "ChatApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_ApplicationUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Categories_CategoryId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Lessons_LessonId",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Comments_CommentId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Lessons_LessonId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Lessons_LessonId",
                table: "Videos");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

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
                table: "PrivateMessages",
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
                name: "DeletedOn",
                table: "PrivateMessages",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PrivateMessages",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "PrivateMessages",
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

            migrationBuilder.CreateIndex(
                name: "IX_Videos_IsDeleted",
                table: "Videos",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_IsDeleted",
                table: "Reports",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessages_IsDeleted",
                table: "PrivateMessages",
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
                name: "IX_AspNetRoles_IsDeleted",
                table: "AspNetRoles",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
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
                name: "FK_ChatApplicationUsers_AspNetUsers_ApplicationUserId",
                table: "ChatApplicationUsers",
                column: "ApplicationUserId",
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
                name: "FK_Comments_AspNetUsers_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
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
                name: "FK_Materials_Lessons_LessonId",
                table: "Materials",
                column: "LessonId",
                principalTable: "Lessons",
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
                name: "FK_Reports_Comments_CommentId",
                table: "Reports",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Lessons_LessonId",
                table: "Reports",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Lessons_LessonId",
                table: "Videos",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_ChatApplicationUsers_AspNetUsers_ApplicationUserId",
                table: "ChatApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatApplicationUsers_Chats_ChatId",
                table: "ChatApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_ApplicationUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Lessons_LessonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Categories_CategoryId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Lessons_LessonId",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Comments_CommentId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Lessons_LessonId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Lessons_LessonId",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Videos_IsDeleted",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Reports_IsDeleted",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_PrivateMessages_IsDeleted",
                table: "PrivateMessages");

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
                name: "IX_AspNetRoles_IsDeleted",
                table: "AspNetRoles");

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
                name: "DeletedOn",
                table: "PrivateMessages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PrivateMessages");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "PrivateMessages");

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
                table: "PrivateMessages",
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 0, "be4ebb8a-b0c4-491a-a983-98e81df9e179", "default@gmail.com", false, false, null, "DEFAULT@GMAIL.COM", "USERNAME", "AQAAAAEAACcQAAAAEEoXBcfA91Us1t6i3Tw6CU+l59MQkMLv/So3aKcH0c7FNJiSv//t/aPRpvYRlwZ9mw==", null, false, "6d524a59-6486-466a-8d59-bdeea5cde694", false, "Username" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 15, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3544), false, "Art" },
                    { 14, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3543), false, "Music" },
                    { 13, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3541), false, "Chemistry" },
                    { 12, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3540), false, "Biology" },
                    { 11, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3539), false, "History" },
                    { 10, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3537), false, "Russian Language" },
                    { 9, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3535), false, "English Language" },
                    { 8, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3531), false, "Civic Education" },
                    { 7, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3529), false, "Literature" },
                    { 6, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3528), false, "Physical Education and Sport" },
                    { 5, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3526), false, "Geography" },
                    { 4, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3524), false, "IT" },
                    { 3, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3522), false, "Informatics" },
                    { 2, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3516), false, "Mathematics" },
                    { 1, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(2735), false, "Bulgarian Language" },
                    { 16, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3546), false, "Technologies and Entrepreneurship" },
                    { 17, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(3547), false, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "DateCreated", "Description", "Grade", "IsApproved", "IsDeleted", "MaterialId", "Name", "VideoId" },
                values: new object[,]
                {
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 1, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(9564), "A lecture about pronouns and when to use them.", 1, true, false, 1, "Pronouns, types", 1 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 2, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(651), "A natural number greater than 1 that is not a product of two smaller natural numbers.", 2, true, false, 2, "Prime numbers", 2 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 3, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(660), "About the C# language and the .NET development Platform. First steps.", 3, true, false, 3, "Developing with C#", 3 },
                    { 4, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 4, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(663), "Data analysis.", 4, true, false, 4, "Excel", 4 },
                    { 5, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 5, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(665), "Eastern European Countries. Their iconomic growth and political stances. Ukraine.", 5, true, false, 5, "Ukraine, Eastern Europe", 5 },
                    { 6, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 6, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(666), "Kicking a ball on the field.", 6, true, false, 6, "Football", 6 },
                    { 7, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 7, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(668), "A peek into Shakespere's art.", 7, true, false, 7, "William Shakespere's 106 sonnet", 7 },
                    { 8, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 8, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(671), "A lecture about rights of the people.", 8, true, false, 8, "Human rights", 8 },
                    { 9, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 9, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(673), "We use modals to show if we believe something is certain, possible or impossible.", 9, true, false, 9, "Modal verbs", 9 },
                    { 10, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 10, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(674), "A lecture about the verbs of motion and when to use them.", 10, true, false, 10, "Verbs of motion", 10 },
                    { 11, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 11, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(678), "A brief peek into our ancestors' life.", 11, true, false, 11, "Peek in the past", 11 },
                    { 12, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 12, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(680), "A lesson about the different types of cells and their differences.", 12, true, false, 12, "Cells. Prokaryotic and Eukaryotic", 12 },
                    { 13, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 13, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(682), "A lesson about acids, they effects on the environtment and usage cases.", 0, true, false, 13, "Acids, Bases and pH", 13 },
                    { 14, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 14, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(684), "Genres, instruments and notation.", 5, true, false, 14, "Popular music", 14 },
                    { 15, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 15, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(685), "Pigments, brushes, bases, matrices.", 1, true, false, 15, "Painting", 15 },
                    { 16, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 16, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(687), "Creating a new business, bearing most of the risks and enjoying most of the rewards.", 2, true, false, 16, "Entrepreneurship", 16 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "Content", "DateCreated", "IsDeleted", "LessonId" },
                values: new object[,]
                {
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "I like it!", new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(6207), false, 1 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "The teacher is awesome.", new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(7961), false, 2 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "This is just great.", new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(7968), false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "DateCreated", "IsDeleted", "LessonId", "Link", "Name", "PublicId" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3246), false, 10, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Russian Language", null },
                    { 12, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3249), false, 12, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Biology", null },
                    { 9, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3243), false, 9, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Modal Verbs", null },
                    { 8, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3240), false, 8, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Human Rights", null },
                    { 16, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3256), false, 16, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Entrepreneurship", null },
                    { 7, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3238), false, 7, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Literature", null },
                    { 13, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3251), false, 13, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Chemistry", null },
                    { 6, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3237), false, 6, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Football", null },
                    { 11, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3248), false, 11, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "History", null },
                    { 14, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3252), false, 14, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Music", null },
                    { 4, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3233), false, 4, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Office Suite", null },
                    { 3, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3231), false, 3, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Coding", null },
                    { 15, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3254), false, 15, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Painting", null },
                    { 2, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3224), false, 2, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Teaching", null },
                    { 1, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(2096), false, 1, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Teaching", null },
                    { 5, new DateTime(2021, 8, 5, 11, 24, 18, 344, DateTimeKind.Utc).AddTicks(3236), false, 5, "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip", "Ukraine", null }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "ApplicationUserId", "CommentId", "DateCreated", "Description", "IsDeleted", "LessonId", "Subject" },
                values: new object[] { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", null, new DateTime(2021, 8, 5, 11, 24, 18, 342, DateTimeKind.Utc).AddTicks(9268), "Bad language in lesson's title.", false, 5, "The language used in title" });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "ContentType", "DateCreated", "IsDeleted", "LessonId", "Link", "Name", "PublicId" },
                values: new object[,]
                {
                    { 11, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6161), false, 11, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053246/welearn-asp-net-core-app/videos/seed/history_sll9r9.mp4", "History", null },
                    { 13, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6278), false, 13, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053225/welearn-asp-net-core-app/videos/seed/chemistry_zpdwl9.mp4", "Chemistry", null },
                    { 14, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6281), false, 14, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053175/welearn-asp-net-core-app/videos/seed/music_x6vt4y.mp4", "Music", null },
                    { 12, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6163), false, 12, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053200/welearn-asp-net-core-app/videos/seed/biology_veyt5f.mp4", "Biology", null },
                    { 15, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6283), false, 15, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053181/welearn-asp-net-core-app/videos/seed/painting_glxyu0.mp4", "Painting", null },
                    { 7, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6155), false, 7, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053256/welearn-asp-net-core-app/videos/seed/literature_u1mriv.mp4", "Literature", null },
                    { 9, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6158), false, 9, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053183/welearn-asp-net-core-app/videos/seed/modal-verbs_jjnya3.mp4", "Modal Verbs", null },
                    { 8, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6157), false, 8, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053261/welearn-asp-net-core-app/videos/seed/human-rights_vbojip.mp4", "Human Rights", null },
                    { 6, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6154), false, 6, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053255/welearn-asp-net-core-app/videos/seed/football_basmoc.mp4", "Football", null },
                    { 5, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6152), false, 5, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053238/welearn-asp-net-core-app/videos/seed/eastern-europe_a7ljx0.mp4", "Ukraine", null },
                    { 4, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6150), false, 4, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053172/welearn-asp-net-core-app/videos/seed/office-suite_lugjnz.mp4", "Office Suite", null },
                    { 3, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6147), false, 3, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053215/welearn-asp-net-core-app/videos/seed/coding_bbc9sv.mp4", "Coding", null },
                    { 2, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6140), false, 2, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053205/welearn-asp-net-core-app/videos/seed/man-teaching_miueor.mp4", "Teaching", null },
                    { 1, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(4733), false, 1, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622056204/welearn-asp-net-core-app/videos/seed/teacher-presenting.mp4", "Teaching", null },
                    { 10, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6160), false, 10, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053192/welearn-asp-net-core-app/videos/seed/russian-language_uaydhx.mp4", "Russian Language", null },
                    { 16, "video/mp4", new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(6285), false, 16, "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053249/welearn-asp-net-core-app/videos/seed/entrepreneurship_ulreso.mp4", "Entrepreneurship", null }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "ApplicationUserId", "CommentId", "DateCreated", "Description", "IsDeleted", "LessonId", "Subject" },
                values: new object[] { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 1, new DateTime(2021, 8, 5, 11, 24, 18, 343, DateTimeKind.Utc).AddTicks(734), "Bad language in comment.", false, null, "Unacceptable behaviour" });

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
                name: "FK_ChatApplicationUsers_AspNetUsers_ApplicationUserId",
                table: "ChatApplicationUsers",
                column: "ApplicationUserId",
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
                name: "FK_Comments_AspNetUsers_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
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
                name: "FK_Materials_Lessons_LessonId",
                table: "Materials",
                column: "LessonId",
                principalTable: "Lessons",
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
                name: "FK_Reports_Comments_CommentId",
                table: "Reports",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Lessons_LessonId",
                table: "Reports",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Lessons_LessonId",
                table: "Videos",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

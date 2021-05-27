using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;

namespace WeLearn.Data.Migrations
{
    public partial class ChangesInEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaterialName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Link = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VideoName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    VideoContentType = table.Column<string>(type: "text", nullable: false),
                    Link = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "character varying(1500)", maxLength: 1500, nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Grade = table.Column<int>(type: "integer", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: true),
                    VideoId = table.Column<int>(type: "integer", nullable: false),
                    MaterialId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: true),
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Subject = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: true),
                    PostId = table.Column<int>(type: "integer", nullable: true),
                    CommentId = table.Column<int>(type: "integer", nullable: true),
                    DateResolved = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsResolved = table.Column<bool>(type: "boolean", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Reports_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8346fdda-bbd2-4905-bcf3-e013c9c77265", "1407719d-9e39-44b0-9690-b9248fabdd23", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateModified", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 0, "2a88f5b4-132e-473e-8c0e-451868042ac0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEKaKGPboN7L3cRmBuQjFtx1J9I9o6/PIRB6URjxUY8hpnl0ak9OnBkUwzCNoTV6OEQ==", null, false, "977b1308-3c3e-4dc8-bf80-7803ce4576ab", false, "Username" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "DateCreated", "DateDeleted", "DateModified", "IsDeleted" },
                values: new object[,]
                {
                    { 17, "Others", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8106), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 16, "Technologies and Entrepreneurship", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8104), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 15, "Art", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8103), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 14, "Music", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8101), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 13, "Chemistry", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8100), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 11, "History", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8098), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 10, "Russian Language", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8096), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 9, "English Language", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8095), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 12, "Biology", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8099), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 7, "Literature", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8092), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 6, "Physical Education and Sport", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8090), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 5, "Geography", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8088), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, "IT", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8086), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 3, "Informatics", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8085), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, "Mathematics", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8081), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 1, "Bulgarian Language", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(7213), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 8, "Civic Education", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8093), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateModified", "IsDeleted", "Link", "MaterialName" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5924), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Russian Language" },
                    { 16, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5932), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Entrepreneurship" },
                    { 15, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5931), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Painting" },
                    { 14, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5929), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Music" },
                    { 13, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5928), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Chemistry" },
                    { 12, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5927), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Biology" },
                    { 11, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5925), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "History" },
                    { 9, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5923), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Modal Verbs" },
                    { 7, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5920), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Literature" },
                    { 6, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5919), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Football" },
                    { 5, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5918), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Ukraine" },
                    { 4, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5917), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Office Suite" },
                    { 3, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5915), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Coding" },
                    { 2, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5912), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Teaching" },
                    { 1, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4672), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Teaching" },
                    { 8, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(5922), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "...", "Human Rights" }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateModified", "IsDeleted", "Link", "VideoContentType", "VideoName" },
                values: new object[,]
                {
                    { 15, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(521), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/painting.mp4", "video/mp4", "Painting" },
                    { 14, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(519), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/music.mp4", "video/mp4", "Music" },
                    { 13, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(518), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/chemistry.mp4", "video/mp4", "Chemistry" },
                    { 12, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(517), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/biology.mp4", "video/mp4", "Biology" },
                    { 11, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(515), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/history.mp4", "video/mp4", "History" },
                    { 10, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(513), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/russian-language.mp4", "video/mp4", "Russian Language" },
                    { 9, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(512), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/modal-verbs.mp4", "video/mp4", "Modal Verbs" },
                    { 5, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(506), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/eastern-europe.mp4", "video/mp4", "Ukraine" },
                    { 7, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(509), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/literature.mp4", "video/mp4", "Literature" },
                    { 6, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(508), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/football.mp4", "video/mp4", "Football" },
                    { 4, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(505), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/office-suite.mp4", "video/mp4", "Office Suite" },
                    { 3, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(503), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/coding.mp4", "video/mp4", "Coding" },
                    { 2, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(500), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/man-teaching.mp4", "video/mp4", "Teaching" },
                    { 1, new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(8845), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/modal-verbs.mp4", "video/mp4", "Teaching" },
                    { 8, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(510), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/human-rights.mp4", "video/mp4", "Human Rights" },
                    { 16, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(522), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/uploads/videos/entrepreneurship.mp4", "video/mp4", "Entrepreneurship" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "DateCreated", "DateDeleted", "DateModified", "Description", "Grade", "IsDeleted", "MaterialId", "PostName", "VideoId" },
                values: new object[,]
                {
                    { 8, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 8, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4043), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about rights of the people.", 0, false, 8, "Human rights", 8 },
                    { 14, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 14, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4053), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genres, instruments and notation.", 0, false, 14, "Popular music", 14 },
                    { 13, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 13, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4051), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lesson about acids, they effects on the environtment and usage cases.", 0, false, 13, "Acids, Bases and pH", 13 },
                    { 12, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 12, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4050), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lesson about the different types of cells and their differences.", 0, false, 12, "Cells. Prokaryotic and Eukaryotic", 12 },
                    { 11, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 11, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4048), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A brief peek into our ancestors' life.", 0, false, 11, "Peek in the past", 11 },
                    { 10, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 10, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4046), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about the verbs of motion and when to use them.", 0, false, 10, "Verbs of motion", 10 },
                    { 9, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 9, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4045), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We use modals to show if we believe something is certain, possible or impossible.", 0, false, 9, "Modal verbs", 9 },
                    { 15, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 15, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4054), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pigments, brushes, bases, matrices.", 0, false, 15, "Painting", 15 },
                    { 16, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 16, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4056), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creating a new business, bearing most of the risks and enjoying most of the rewards.", 0, false, 16, "Entrepreneurship", 16 },
                    { 6, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 6, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4040), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kicking a ball on the field.", 0, false, 6, "Football", 6 },
                    { 5, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 5, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4039), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern European Countries. Their iconomic growth and political stances. Ukraine.", 0, false, 5, "Ukraine, Eastern Europe", 5 },
                    { 4, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 4, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4036), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data analysis.", 0, false, 4, "Excel", 4 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 3, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4034), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "About the C# language and the .NET development Platform. First steps.", 0, false, 3, "Developing with C#", 3 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 2, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4031), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A natural number greater than 1 that is not a product of two smaller natural numbers.", 0, false, 2, "Prime numbers", 2 },
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 1, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(2790), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about pronouns and when to use them.", 0, false, 1, "Pronouns, types", 1 },
                    { 7, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 7, new DateTime(2021, 5, 3, 19, 46, 9, 531, DateTimeKind.Utc).AddTicks(4041), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A peek into Shakespere's art.", 0, false, 7, "William Shakespere's 106 sonnet", 7 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "ApplicationUserId", "CommentId", "DateCreated", "DateDeleted", "DateModified", "DateResolved", "Description", "IsDeleted", "IsResolved", "PostId", "Subject" },
                values: new object[] { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", null, new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(4348), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "This username is unacceptable.", false, false, null, "Bad words in username" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "Content", "DateCreated", "DateDeleted", "DateModified", "IsDeleted", "PostId" },
                values: new object[,]
                {
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "I like it!", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(64), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "Good, but can be imroved.", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(1765), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "This is very nice.", new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(1770), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "ApplicationUserId", "CommentId", "DateCreated", "DateDeleted", "DateModified", "DateResolved", "Description", "IsDeleted", "IsResolved", "PostId", "Subject" },
                values: new object[] { 1, null, null, new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(2548), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bad language in lesson's title.", false, false, 5, "The language used in title" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "ApplicationUserId", "CommentId", "DateCreated", "DateDeleted", "DateModified", "DateResolved", "Description", "IsDeleted", "IsResolved", "PostId", "Subject" },
                values: new object[] { 3, null, 1, new DateTime(2021, 5, 3, 19, 46, 9, 530, DateTimeKind.Utc).AddTicks(4756), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bad language in comment.", false, false, null, "Swearing in comment" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_MaterialId",
                table: "Posts",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_VideoId",
                table: "Posts",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ApplicationUserId",
                table: "Reports",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CommentId",
                table: "Reports",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_PostId",
                table: "Reports",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Videos");
        }
    }
}

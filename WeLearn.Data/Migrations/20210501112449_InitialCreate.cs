using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WeLearn.Data.Migrations
{
    public partial class InitialCreate : Migration
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
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
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
                    FirstName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    LastName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
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
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaterialName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Link = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialId);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    VideoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VideoName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Link = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.VideoId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    PostId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "character varying(1500)", maxLength: 1500, nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Grade = table.Column<int>(type: "integer", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    VideoId = table.Column<int>(type: "integer", nullable: false),
                    MaterialId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "VideoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Subject = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: true),
                    PostId = table.Column<int>(type: "integer", nullable: true),
                    CommentId = table.Column<int>(type: "integer", nullable: true),
                    DateResolved = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsResolved = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateModified", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 0, "26004cab-20eb-4fcb-8369-223b2c7fb1e1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Firstname", "Lastname", false, null, null, null, "AQAAAAEAACcQAAAAEDdhi6iAR4o/tWXtpGMmV2/iNz1OS9hcPMnItSS193eDYA0af58DggNo9WbBv5DO2A==", null, false, "db27fca2-b75b-400f-854a-f9bc6a643bea", false, "Username" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "DateCreated", "DateDeleted", "DateModified" },
                values: new object[,]
                {
                    { 16, "Technologies and Entrepreneurship", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8795), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Art", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8793), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Music", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8792), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Chemistry", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8791), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "History", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8787), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Russian Language", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8786), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "English Language", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8785), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Biology", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8788), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Literature", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8781), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Physical Education and Sport", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8779), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Geography", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8778), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "IT", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8776), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Informatics", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8775), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Mathematics", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8772), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "Bulgarian Language", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8362), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Civic Education", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(8783), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "DateCreated", "DateDeleted", "DateModified", "Link", "MaterialName" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7387), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1561336313-0bd5e0b27ec8?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Coffee" },
                    { 16, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7395), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1558387886-d6988f49a2e0?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Statue" },
                    { 15, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7394), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1524419986249-348e8fa6ad4a?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Nightcity" },
                    { 14, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7392), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1567796422106-8f577f1b715b?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=675&q=80", "Jars" },
                    { 13, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7391), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1598125444907-f01590d16db5?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Snail" },
                    { 12, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7390), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1562589539-346d763b0513?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=676&q=80", "House" },
                    { 11, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7388), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1525534240745-6b6f65e8a25f?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1490&q=80", "Flags" },
                    { 9, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7385), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1600716051809-e997e11a5d52?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1333&q=80", "Lemons" },
                    { 8, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7384), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1529321044792-949d1f03e61e?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1490&q=80", "Fire" },
                    { 7, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7381), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1598125442810-7d196739bb5b?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Moss" },
                    { 6, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7380), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1598350742412-8fe67cd5375b?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=1350&q=80", "Concrete Building" },
                    { 5, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7378), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1598125445561-f1ab380e2cc3?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=1350&q=80", "Textile" },
                    { 4, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7377), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1532365673558-f9bb768644e7?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Greeny" },
                    { 3, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7376), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1615220368123-9bb8faf4221b?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1302&q=80", "Fancy Setup" },
                    { 2, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(7371), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1598125445316-6aab4ec2b38c?ixid=MXwxMjA3fDB8MHxzZWFyY2h8MTA5fHxzYW1wbGV8ZW58MHx8MHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", "Rocks" },
                    { 1, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(6297), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1598350740930-8dc9c2e1774a?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=1350&q=80", "Whitey" }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "VideoId", "DateCreated", "DateDeleted", "DateModified", "Link", "VideoName" },
                values: new object[,]
                {
                    { 14, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(796), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample2.mp4", "Jars" },
                    { 13, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(795), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample.mp4", "Snail" },
                    { 12, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(794), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample2.mp4", "House" },
                    { 11, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(793), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample.mp4", "Flags" },
                    { 10, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(791), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample2.mp4", "Coffee" },
                    { 9, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(789), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample.mp4", "Lemons" },
                    { 8, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(788), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample2.mp4", "Fire" },
                    { 5, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(784), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample.mp4", "Textile" },
                    { 6, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(785), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample2.mp4", "Concrete Building" },
                    { 15, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(797), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample.mp4", "Nightcity" },
                    { 4, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(783), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample2.mp4", "Greeny" },
                    { 3, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(782), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample.mp4", "Fancy Setup" },
                    { 2, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(778), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample2.mp4", "Rocks" },
                    { 1, new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(9863), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample.mp4", "Whitey" },
                    { 7, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(786), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample.mp4", "Moss" },
                    { 16, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(799), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/uploads/videos/sample2.mp4", "Statue" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "ApplicationUserId", "CategoryId", "DateCreated", "DateDeleted", "DateModified", "Description", "Grade", "IsDeleted", "MaterialId", "PostName", "VideoId" },
                values: new object[,]
                {
                    { 8, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 8, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4666), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about rights of the people.", 0, false, 8, "Human rights", 8 },
                    { 14, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 14, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4684), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genres, instruments and notation.", 0, false, 14, "Medieval music", 14 },
                    { 13, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 13, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4683), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lesson about acids, they effects on the environtment and usage cases.", 0, false, 13, "Acids, Bases and pH", 13 },
                    { 12, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 12, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4677), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lesson about the different types of cells and their differences.", 0, false, 12, "Cells. Prokaryotic and Eukaryotic", 12 },
                    { 11, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 11, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4673), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lesson about the First Bulgarian Empire, founded 681 in Pliska.", 0, false, 11, "First Bulgarian Empire Part I", 11 },
                    { 10, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 10, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4671), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about the verbs of motion and when to use them.", 0, false, 10, "Verbs of motion", 10 },
                    { 9, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 9, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4668), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We use modals to show if we believe something is certain, possible or impossible.", 0, false, 9, "Modal verbs", 9 },
                    { 15, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 15, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4688), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pigments, brushes, bases, matrices.", 0, false, 15, "Painting", 15 },
                    { 16, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 16, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4689), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creating a new business, bearing most of the risks and enjoying most of the rewards.", 0, false, 16, "Entrepreneurship", 16 },
                    { 6, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 6, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4661), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kicking a ball on the field.", 0, false, 6, "Football", 6 },
                    { 5, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 5, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4558), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern European Countries. Their iconomic growth and political stances. Bulgaria.", 0, false, 5, "Bulgaria, Eastern Europe", 5 },
                    { 4, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 4, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4556), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data analysis.", 0, false, 4, "Excel", 4 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 3, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4553), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "About the C# language and the .NET development Platform. First steps.", 0, false, 3, "Developing with C#", 3 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 2, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4534), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A natural number greater than 1 that is not a product of two smaller natural numbers.", 0, false, 2, "Prime numbers", 2 },
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 1, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(3324), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lecture about pronouns and when to use them.", 0, false, 1, "Pronouns, types", 1 },
                    { 7, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", 7, new DateTime(2021, 5, 1, 11, 24, 48, 987, DateTimeKind.Utc).AddTicks(4665), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A peek into Shakespere's art.", 0, false, 7, "William Shakespere's 106 sonnet", 7 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportId", "ApplicationUserId", "CommentId", "DateCreated", "DateDeleted", "DateModified", "DateResolved", "Description", "IsDeleted", "IsResolved", "PostId", "Subject" },
                values: new object[] { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", null, new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(5354), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "This username is unacceptable.", false, false, null, "Bad words in username" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "ApplicationUserId", "Content", "DateCreated", "DateDeleted", "DateModified", "IsDeleted", "PostId" },
                values: new object[,]
                {
                    { 1, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "I like it!", new DateTime(2021, 5, 1, 11, 24, 48, 985, DateTimeKind.Utc).AddTicks(9126), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 2, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "Good, but can be imroved.", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(1915), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 3, "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", "This is very nice.", new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(1927), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportId", "ApplicationUserId", "CommentId", "DateCreated", "DateDeleted", "DateModified", "DateResolved", "Description", "IsDeleted", "IsResolved", "PostId", "Subject" },
                values: new object[] { 1, null, null, new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(4047), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bad language in lesson's title.", false, false, 5, "The language used in title" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportId", "ApplicationUserId", "CommentId", "DateCreated", "DateDeleted", "DateModified", "DateResolved", "Description", "IsDeleted", "IsResolved", "PostId", "Subject" },
                values: new object[] { 3, null, 1, new DateTime(2021, 5, 1, 11, 24, 48, 986, DateTimeKind.Utc).AddTicks(5753), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bad language in comment.", false, false, null, "Swearing in comment" });

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

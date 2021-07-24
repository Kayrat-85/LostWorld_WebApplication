using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace theLostWorld.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anthropogenesis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anthropogenesis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DinosaursAquatics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DinosaursAquatics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DinosaursFlyings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DinosaursFlyings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DinosaursHerbivore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DinosaursHerbivore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DinosaursPredator",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DinosaursPredator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MammalsHerbivores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MammalsHerbivores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MammalsPredators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MammalsPredators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TextFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "29c47b46-9221-4ffb-9613-0ecf5fc66ace", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b62472e-4f66-49fa-a20f-e7685b9565d8", 0, "377e4853-149a-4439-8cbb-b09d13181875", "kayrat_tekebayev@mail.ru", true, false, null, "KAYRAT_TEKEBAYEV@MAIL.RU", "ADMIN", "AQAAAAEAACcQAAAAEF5XfBvfBLEZzBtxLbY5hh0sppTeGzMJHa3bvSyDMuMuaXhwqzy+DzNQ8FBRTYIzlg==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("5595b92d-23ec-456c-a29d-531d052b0543"), "PageDevonian", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6581), null, null, null, null, "Содержание заполняется администратором", "Девонский период", null },
                    { new Guid("e5345fec-bff0-4ca4-bb70-073506051976"), "PageSilurian", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6525), null, null, null, null, "Содержание заполняется администратором", "Силурийский период", null },
                    { new Guid("2656ced9-2652-4319-8d73-682ae34a542b"), "PageOrdovician", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6471), null, null, null, null, "Содержание заполняется администратором", "Ордовикский период", null },
                    { new Guid("38ea5137-e57d-4be5-a098-e56459caf2ed"), "PageCambrian", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6415), null, null, null, null, "Содержание заполняется администратором", "Кембрийский период", null },
                    { new Guid("6dbe2258-400e-4d1b-853d-4331cac8dec7"), "PageQuaternary", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6355), null, null, null, null, "Содержание заполняется администратором", "Четвертичный период", null },
                    { new Guid("6d9eecb0-2912-4883-ac8a-045a3c0c769a"), "PageNeogene", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6301), null, null, null, null, "Содержание заполняется администратором", "Неогеновый период", null },
                    { new Guid("9edf8766-b00f-4781-a358-a8650ba78507"), "PagePaleogene", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6246), null, null, null, null, "Содержание заполняется администратором", "Палеогеновый период", null },
                    { new Guid("1e7a21df-ad48-4872-a325-687f9414c361"), "PageCretaceous", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6193), null, null, null, null, "Содержание заполняется администратором", "Меловой период", null },
                    { new Guid("b4aaa792-092a-4a9e-9c4d-2b6b916a65f8"), "PageJurassic", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6137), null, null, null, null, "Содержание заполняется администратором", "Юрский период", null },
                    { new Guid("14372a40-774c-4551-8215-c557ccc43c14"), "PageTriassic", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6083), null, null, null, null, "Содержание заполняется администратором", "Триасовый период", null },
                    { new Guid("67450832-3ede-4420-861f-a04d4f536e30"), "PageMyWebProject", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6028), null, null, null, null, "Содержание заполняется администратором", "О проекте", null },
                    { new Guid("c023faf9-369d-4cb4-a8dd-8d2ccbf3cb33"), "PageAboutMe", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(5971), null, null, null, null, "Содержание заполняется администратором", "Контакты", null },
                    { new Guid("0e2f8edc-13d3-427d-9e68-ce83b3a563bf"), "PageAnthropogenesis", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(5908), null, null, null, null, "Содержание заполняется администратором", "Антропогенез", null },
                    { new Guid("8163839a-dce8-402d-be29-f57615395f28"), "PageMammalsHerbivores", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(5849), null, null, null, null, "Содержание заполняется администратором", "Травояднык млекопитающие", null },
                    { new Guid("04e664e6-26d9-4fc7-ad2e-7cc0894a7d27"), "PageMammalsPredators", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(5766), null, null, null, null, "Содержание заполняется администратором", "Хищные млекопитающие", null },
                    { new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"), "PageNews", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(5530), null, null, null, null, "Содержание заполняется администратором", "Новости", null },
                    { new Guid("2f604579-3dd8-4048-b4ef-300484cd4a99"), "PageDinosaursAquatic", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(5461), null, null, null, null, "Содержание заполняется администратором", "Водные динозавры", null },
                    { new Guid("f66c3438-7fae-4b5e-936d-b030f4dfffb1"), "PageDinosaursFlyings", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(5333), null, null, null, null, "Содержание заполняется администратором", "Летающие динозавры", null },
                    { new Guid("a463fe1a-74dd-4f2f-8f09-1ca13afdffd3"), "PageDinosaursHerbivores", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(5269), null, null, null, null, "Содержание заполняется администратором", "Травоядные динозавры", null },
                    { new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), "PageDinosaursPredators", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(5151), null, null, null, null, "Содержание заполняется администратором", "Хищные динозавры", null },
                    { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), "PageIndex", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(798), null, null, null, null, "Содержание заполняется администратором", "Главная", null },
                    { new Guid("5a8ed9ad-6a10-499e-b475-4b693bc2da70"), "PageCarboniferous", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6635), null, null, null, null, "Содержание заполняется администратором", "Каменноугольный период", null },
                    { new Guid("613faf6e-200b-4081-ac67-d0dd4d09f506"), "PagePermian", new DateTime(2021, 7, 7, 16, 59, 38, 86, DateTimeKind.Utc).AddTicks(6688), null, null, null, null, "Содержание заполняется администратором", "Пермский период", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d8" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anthropogenesis");

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
                name: "DinosaursAquatics");

            migrationBuilder.DropTable(
                name: "DinosaursFlyings");

            migrationBuilder.DropTable(
                name: "DinosaursHerbivore");

            migrationBuilder.DropTable(
                name: "DinosaursPredator");

            migrationBuilder.DropTable(
                name: "MammalsHerbivores");

            migrationBuilder.DropTable(
                name: "MammalsPredators");

            migrationBuilder.DropTable(
                name: "ServiceItems");

            migrationBuilder.DropTable(
                name: "TextFields");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

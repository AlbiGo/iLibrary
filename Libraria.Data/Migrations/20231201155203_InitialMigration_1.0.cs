using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Libraria.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategorite",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorite", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kerkesat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LiberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KerkuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    KerksesaPrind = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmerLexuesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MbiemerLexuesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DitelindjaLexuesit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    test = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKerkese = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAprovimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataRefuzimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataMarrjes = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataKthimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataTerheqjes = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kerkesat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KerkesatPrind",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NmrLibrave = table.Column<int>(type: "int", nullable: false),
                    KerkuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    EmerLexuesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MbiemerLexuesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DitelindjaLexuesit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataKerkese = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAprovimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataRefuzimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataMarrjes = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataKthimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataTerheqjes = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KerkesatPrind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KthimLibri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarrjeLIbri = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataKthimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusKthimLibri = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KthimLibri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lexuesit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NmrId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statusi = table.Column<bool>(type: "bit", nullable: true),
                    DataRegj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FotoProfiliURl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KarteLeximiURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datelindja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qyteti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodiPostar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendlindja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BardCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Universiteti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atesia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memesia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumriId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataSkadimitTeKartes = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Karta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lexuesit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perdoruesit",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statusi = table.Column<bool>(type: "bit", nullable: true),
                    DataRegj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FotoProfiliURl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Perdoruesit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuset",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuset", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StatusKthimLibri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusKthimLibri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipiLeshimLibri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipiLeshimLibri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Librat",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autori = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kategoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Statusi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataRegj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPerditesimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Vendi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoLibbriUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotoLibri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StatusID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Librat_Kategorite_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategorite",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Librat_Statuset_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Statuset",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "inventari",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LiberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SasiaNeMagazine = table.Column<int>(type: "int", nullable: true),
                    NevojePerFurnuzim = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_inventari_Librat_LiberId",
                        column: x => x.LiberId,
                        principalTable: "Librat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LIber_Perdorues",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LiberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aprovuesi = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AfatiKthimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataMarrjes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataKthimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    AprovuesId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LexuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIber_Perdorues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LIber_Perdorues_Lexuesit_LexuesId",
                        column: x => x.LexuesId,
                        principalTable: "Lexuesit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LIber_Perdorues_Librat_LiberId",
                        column: x => x.LiberId,
                        principalTable: "Librat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LIber_Perdorues_Perdoruesit_AprovuesId",
                        column: x => x.AprovuesId,
                        principalTable: "Perdoruesit",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MarrjeLibri",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LexuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LiberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aprovuesi = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TipiLeshimit = table.Column<int>(type: "int", nullable: false),
                    KerkeseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AfatiKthimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataMarrjes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataKthimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    AprovuesId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarrjeLibri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MarrjeLibri_Lexuesit_LexuesId",
                        column: x => x.LexuesId,
                        principalTable: "Lexuesit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarrjeLibri_Librat_LiberId",
                        column: x => x.LiberId,
                        principalTable: "Librat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarrjeLibri_Perdoruesit_AprovuesId",
                        column: x => x.AprovuesId,
                        principalTable: "Perdoruesit",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5533496f-4610-4b49-ab44-798ecb5ad845", null, "Menaxher", "Menaxher" },
                    { "a0e188ee-4e93-4a00-b4e1-f0d3d11d8ea2", null, "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("85af25c5-c475-4243-ae76-8c863c839ee7"), "Roman" },
                    { new Guid("973ccc51-b096-4538-becd-2e5ecf312c87"), "Drama" },
                    { new Guid("a458a592-6eb7-470b-8c06-f59bafe8d641"), "Biografi" },
                    { new Guid("cdb4e79c-fa02-43cc-83f1-664049bddc1c"), "POezi" },
                    { new Guid("e6a5a93d-c689-4dd3-92eb-4ea835e7366c"), "Proze" },
                    { new Guid("f5512214-2186-4c26-88e0-8549c958ccb8"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "StatusKthimLibri",
                columns: new[] { "Id", "Pershkrimi" },
                values: new object[,]
                {
                    { 1, "I rregullt" },
                    { 2, "I demtuar" },
                    { 3, "I vonuar" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("34417029-87b0-430a-a565-868a9f21117c"), "I Demtuar" },
                    { new Guid("439eb316-5e96-4dd7-a227-0bf90bf27920"), "I Lire" },
                    { new Guid("6813e0c4-da7b-480a-9754-9a1227678b63"), "I Mbaruar" },
                    { new Guid("91e82fb1-6a2f-4273-80c7-af59fe8f7bb3"), "I Hequr" },
                    { new Guid("f7bd5bad-a58a-413d-baa8-b133b002dfc7"), "I dhene" }
                });

            migrationBuilder.InsertData(
                table: "TipiLeshimLibri",
                columns: new[] { "Id", "Pershkrimi" },
                values: new object[,]
                {
                    { 1, "Leshim prane sportelit" },
                    { 2, "Leshim me kerkese online" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_inventari_LiberId",
                table: "inventari",
                column: "LiberId");

            migrationBuilder.CreateIndex(
                name: "IX_LIber_Perdorues_AprovuesId",
                table: "LIber_Perdorues",
                column: "AprovuesId");

            migrationBuilder.CreateIndex(
                name: "IX_LIber_Perdorues_LexuesId",
                table: "LIber_Perdorues",
                column: "LexuesId");

            migrationBuilder.CreateIndex(
                name: "IX_LIber_Perdorues_LiberId",
                table: "LIber_Perdorues",
                column: "LiberId");

            migrationBuilder.CreateIndex(
                name: "IX_Librat_KategoriID",
                table: "Librat",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Librat_StatusID",
                table: "Librat",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_MarrjeLibri_AprovuesId",
                table: "MarrjeLibri",
                column: "AprovuesId");

            migrationBuilder.CreateIndex(
                name: "IX_MarrjeLibri_LexuesId",
                table: "MarrjeLibri",
                column: "LexuesId");

            migrationBuilder.CreateIndex(
                name: "IX_MarrjeLibri_LiberId",
                table: "MarrjeLibri",
                column: "LiberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "inventari");

            migrationBuilder.DropTable(
                name: "Kerkesat");

            migrationBuilder.DropTable(
                name: "KerkesatPrind");

            migrationBuilder.DropTable(
                name: "KthimLibri");

            migrationBuilder.DropTable(
                name: "LIber_Perdorues");

            migrationBuilder.DropTable(
                name: "MarrjeLibri");

            migrationBuilder.DropTable(
                name: "StatusKthimLibri");

            migrationBuilder.DropTable(
                name: "TipiLeshimLibri");

            migrationBuilder.DropTable(
                name: "Lexuesit");

            migrationBuilder.DropTable(
                name: "Librat");

            migrationBuilder.DropTable(
                name: "Perdoruesit");

            migrationBuilder.DropTable(
                name: "Kategorite");

            migrationBuilder.DropTable(
                name: "Statuset");
        }
    }
}

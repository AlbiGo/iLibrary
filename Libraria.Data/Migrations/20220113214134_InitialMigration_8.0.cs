using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_80 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12c075e0-3059-4bd9-a138-81a793555543");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca59dbd7-87db-4768-9a1c-00e09acb544f");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("2f3f464d-9949-45de-87a9-7d9c870ea0bd"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("66600e9c-ecf8-4c95-8b8d-13660445bd13"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("8b482deb-90f8-4cb1-a80a-164eee5bd11c"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("c03ea887-dce2-4477-9dd0-9b5759db0ba7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("c8662043-df56-47f2-8c6f-ce2dea055247"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("f5fb70be-bb05-49d0-9903-6386f0b4081a"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("3c3e7e04-8274-411e-8c7e-8a6b197eaa5d"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("472e7eeb-588a-40bd-91bd-c76aa2a57f63"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("6a387a67-e744-47c2-a294-b662ede233b4"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("d2b44a8e-3587-4664-80de-92f29e571984"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("e152b5b6-e94d-45db-9bf8-6ff473149ceb"));

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
                        name: "FK_MarrjeLibri_AspNetUsers_AprovuesId",
                        column: x => x.AprovuesId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56deda7d-415f-494b-9a5c-9732b9eeb897", "dbb371e8-284b-4f76-9bd8-4fbbd6e5abab", "Menaxher", "Menaxher" },
                    { "8d677183-440e-4606-9dc2-a1a0206be6c7", "088ea39f-7838-48a0-a688-7a1237f68af1", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("92b8bf84-d0d4-404b-aad1-24f4cd1ddda1"), "Roman" },
                    { new Guid("359fafc0-8ef8-47f3-8208-e244a51045b7"), "Proze" },
                    { new Guid("7b5af2b3-95b1-4e14-a03a-8657d9de0899"), "POezi" },
                    { new Guid("57eba866-d618-4615-91f4-dbe3ab4e7627"), "Drama" },
                    { new Guid("08dfc3e5-af49-4648-bd0f-2a8fcff51fee"), "Biografi" },
                    { new Guid("31a599a2-deb2-4ec3-a8b3-76fd06eea2d7"), "Histori" }
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
                    { new Guid("7bddd6f8-4043-4a94-a1f9-2f11ebd0f899"), "I Lire" },
                    { new Guid("6539ffee-0e6b-48ff-9fbd-fe4df0e9496c"), "I dhene" },
                    { new Guid("8d301399-200c-441e-892c-3b00df171482"), "I Demtuar" },
                    { new Guid("47804644-6f18-45bf-bca6-34d93a207004"), "I Hequr" },
                    { new Guid("50955a30-aee8-428f-8451-2faec336512d"), "I Mbaruar" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KthimLibri");

            migrationBuilder.DropTable(
                name: "MarrjeLibri");

            migrationBuilder.DropTable(
                name: "StatusKthimLibri");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56deda7d-415f-494b-9a5c-9732b9eeb897");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d677183-440e-4606-9dc2-a1a0206be6c7");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("08dfc3e5-af49-4648-bd0f-2a8fcff51fee"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("31a599a2-deb2-4ec3-a8b3-76fd06eea2d7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("359fafc0-8ef8-47f3-8208-e244a51045b7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("57eba866-d618-4615-91f4-dbe3ab4e7627"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7b5af2b3-95b1-4e14-a03a-8657d9de0899"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("92b8bf84-d0d4-404b-aad1-24f4cd1ddda1"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("47804644-6f18-45bf-bca6-34d93a207004"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("50955a30-aee8-428f-8451-2faec336512d"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("6539ffee-0e6b-48ff-9fbd-fe4df0e9496c"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("7bddd6f8-4043-4a94-a1f9-2f11ebd0f899"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("8d301399-200c-441e-892c-3b00df171482"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12c075e0-3059-4bd9-a138-81a793555543", "66968421-307b-490b-a97e-a511266200ff", "Menaxher", "Menaxher" },
                    { "ca59dbd7-87db-4768-9a1c-00e09acb544f", "f6da1165-edff-49ad-b1f3-21e7f0839fce", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("66600e9c-ecf8-4c95-8b8d-13660445bd13"), "Roman" },
                    { new Guid("2f3f464d-9949-45de-87a9-7d9c870ea0bd"), "Proze" },
                    { new Guid("c8662043-df56-47f2-8c6f-ce2dea055247"), "POezi" },
                    { new Guid("f5fb70be-bb05-49d0-9903-6386f0b4081a"), "Drama" },
                    { new Guid("8b482deb-90f8-4cb1-a80a-164eee5bd11c"), "Biografi" },
                    { new Guid("c03ea887-dce2-4477-9dd0-9b5759db0ba7"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("472e7eeb-588a-40bd-91bd-c76aa2a57f63"), "I Lire" },
                    { new Guid("e152b5b6-e94d-45db-9bf8-6ff473149ceb"), "I dhene" },
                    { new Guid("d2b44a8e-3587-4664-80de-92f29e571984"), "I Demtuar" },
                    { new Guid("3c3e7e04-8274-411e-8c7e-8a6b197eaa5d"), "I Hequr" },
                    { new Guid("6a387a67-e744-47c2-a294-b662ede233b4"), "I Mbaruar" }
                });
        }
    }
}

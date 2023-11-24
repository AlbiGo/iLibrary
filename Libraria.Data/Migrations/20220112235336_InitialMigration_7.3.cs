using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_73 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56cd2057-e170-4d9e-b9b1-5b24fe371cb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ea1a58f-1a2b-4548-9be8-240ace0749fe");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("05335f57-0836-4121-b658-bd346415ad2e"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("48a55411-922b-4979-94e6-645611827b6b"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("5b441832-84af-4202-9d0f-0e113a1c2487"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7db8ec74-00a0-4a80-b089-4900d4dac40a"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7f48f7e7-a25f-4c86-ada3-19c7403d00c9"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("8bcad12e-23db-482c-8e39-84bd00691357"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("25db1d10-003d-42cb-a4f1-93e1e3e54ab7"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("8643ed43-613c-4dc0-aa9e-075e0f8a23ff"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a1a0e786-0b9e-42bc-b194-0aa94536fa89"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("d00622ec-c882-45fa-87dd-de3438c1d9e3"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("f960e60a-5cc9-45b1-a4ca-e3b36de75bf9"));

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

            migrationBuilder.InsertData(
                table: "TipiLeshimLibri",
                columns: new[] { "Id", "Pershkrimi" },
                values: new object[,]
                {
                    { 1, "Leshim prane sportelit" },
                    { 2, "Leshim me kerkese online" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipiLeshimLibri");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ea1a58f-1a2b-4548-9be8-240ace0749fe", "048762f4-d2a1-48d7-816e-34d48a7e00a5", "Menaxher", "Menaxher" },
                    { "56cd2057-e170-4d9e-b9b1-5b24fe371cb1", "5f29654c-51af-4742-89d1-532a3f025514", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("8bcad12e-23db-482c-8e39-84bd00691357"), "Roman" },
                    { new Guid("7f48f7e7-a25f-4c86-ada3-19c7403d00c9"), "Proze" },
                    { new Guid("48a55411-922b-4979-94e6-645611827b6b"), "POezi" },
                    { new Guid("5b441832-84af-4202-9d0f-0e113a1c2487"), "Drama" },
                    { new Guid("05335f57-0836-4121-b658-bd346415ad2e"), "Biografi" },
                    { new Guid("7db8ec74-00a0-4a80-b089-4900d4dac40a"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("25db1d10-003d-42cb-a4f1-93e1e3e54ab7"), "I Lire" },
                    { new Guid("f960e60a-5cc9-45b1-a4ca-e3b36de75bf9"), "I dhene" },
                    { new Guid("8643ed43-613c-4dc0-aa9e-075e0f8a23ff"), "I Demtuar" },
                    { new Guid("a1a0e786-0b9e-42bc-b194-0aa94536fa89"), "I Hequr" },
                    { new Guid("d00622ec-c882-45fa-87dd-de3438c1d9e3"), "I Mbaruar" }
                });
        }
    }
}

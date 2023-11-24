using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_93 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd693361-eeef-4470-99e3-fca79d975701");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee973243-24a3-494c-b299-96d1610c7b5a");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("0ffa1c98-7dff-4f41-9939-ebf80942cace"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("32368d91-8ea6-4a98-b3b8-66d7b6a0ebc7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("3827594d-b8cd-4df2-85ed-bc1971c750ed"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("4dd8dd09-6e99-4307-855a-025669eaea03"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7b1538e1-6dcd-4cf8-bf8c-2acb5d5aced2"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("97d4224a-591f-40ee-90ea-6fa07534c726"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("89254923-cadc-45b8-bd73-a7df165ffa3c"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("8fb84159-203f-405b-bcf8-74f9b76265d2"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a8798158-1048-4812-8d4f-04b64f63f29b"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("d9358b17-1e1b-4bfc-be4a-436b31a81384"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("fada70b9-298d-4647-b109-f76b022010c4"));

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

           

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("78693a80-3fb7-4b98-9d25-2dbc5dba9e6c"), "Roman" },
                    { new Guid("d8f62828-1b6d-4ed2-bf2a-36657d8aaabb"), "Proze" },
                    { new Guid("dbb65966-3642-459e-b291-47b1d271f0bc"), "POezi" },
                    { new Guid("65d4985c-2da8-497c-a1ef-05af9811c8ea"), "Drama" },
                    { new Guid("7bd68253-6f15-49ad-b815-40666bd583f0"), "Biografi" },
                    { new Guid("47742662-8960-4a49-b195-d1d5261f337c"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("8f9ed920-5a96-46ea-a1b3-cc1349327144"), "I Lire" },
                    { new Guid("ba6a8f75-be2a-4b85-84d3-b098f4ff8616"), "I dhene" },
                    { new Guid("185fbec3-0ffa-41f6-9a2b-1ca58cadceac"), "I Demtuar" },
                    { new Guid("3093051c-f17c-4468-8265-7e78545289fd"), "I Hequr" },
                    { new Guid("90b0f1e8-c716-41e6-a50e-f300be9a30ab"), "I Mbaruar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KerkesatPrind");

          

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("47742662-8960-4a49-b195-d1d5261f337c"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("65d4985c-2da8-497c-a1ef-05af9811c8ea"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("78693a80-3fb7-4b98-9d25-2dbc5dba9e6c"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7bd68253-6f15-49ad-b815-40666bd583f0"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("d8f62828-1b6d-4ed2-bf2a-36657d8aaabb"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("dbb65966-3642-459e-b291-47b1d271f0bc"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("185fbec3-0ffa-41f6-9a2b-1ca58cadceac"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("3093051c-f17c-4468-8265-7e78545289fd"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("8f9ed920-5a96-46ea-a1b3-cc1349327144"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("90b0f1e8-c716-41e6-a50e-f300be9a30ab"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("ba6a8f75-be2a-4b85-84d3-b098f4ff8616"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ee973243-24a3-494c-b299-96d1610c7b5a", "ebbb7429-cdcb-488e-b9ba-40e3eea7b67f", "Menaxher", "Menaxher" },
                    { "cd693361-eeef-4470-99e3-fca79d975701", "707223a9-076e-4712-b8f6-b3bad1867bbd", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("97d4224a-591f-40ee-90ea-6fa07534c726"), "Roman" },
                    { new Guid("3827594d-b8cd-4df2-85ed-bc1971c750ed"), "Proze" },
                    { new Guid("4dd8dd09-6e99-4307-855a-025669eaea03"), "POezi" },
                    { new Guid("32368d91-8ea6-4a98-b3b8-66d7b6a0ebc7"), "Drama" },
                    { new Guid("7b1538e1-6dcd-4cf8-bf8c-2acb5d5aced2"), "Biografi" },
                    { new Guid("0ffa1c98-7dff-4f41-9939-ebf80942cace"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("a8798158-1048-4812-8d4f-04b64f63f29b"), "I Lire" },
                    { new Guid("89254923-cadc-45b8-bd73-a7df165ffa3c"), "I dhene" },
                    { new Guid("d9358b17-1e1b-4bfc-be4a-436b31a81384"), "I Demtuar" },
                    { new Guid("8fb84159-203f-405b-bcf8-74f9b76265d2"), "I Hequr" },
                    { new Guid("fada70b9-298d-4647-b109-f76b022010c4"), "I Mbaruar" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_70 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "754f95b9-809b-4ffd-bed3-87f263a0e5d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7c1c477-43c3-49fc-9d5a-ce67facd06db");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("0bd67ea9-8d27-442d-bc1a-7176664ea2cc"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("2f3c6ada-7b17-4cfd-ab79-56c189b852c7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("471a491f-4144-4966-ad55-404345869a4a"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("50fceece-51ff-4f8d-b69d-6ca8bc62da79"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("66c851be-52a5-4982-abbe-396ce00f789f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7b0525d2-0986-4744-b71c-54097e34e5fd"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("9235c074-69b0-4347-989f-b2cfb0d7420a"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("9873724d-ced3-4396-863c-704a545a6af6"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a9ef03d0-30b3-47e5-b374-c4552adfb7d3"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("b16287e7-31b2-4353-b316-17841cbc71e1"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("b27e94fe-9f90-40a3-a955-4bf3ae860ab0"));

            migrationBuilder.CreateTable(
                name: "Kerkesat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LiberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KerkuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    DataKerkese = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAprovimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataRefuzimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataMarrjes = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataKthimit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kerkesat", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "536b5752-a1e0-4f0f-98a6-7ce389b3d7e6", "d0a4b049-a5de-4c90-b3d7-4cf3d2eb9d78", "Menaxher", "Menaxher" },
                    { "44e0acf4-1b4e-4fe2-94da-f1060c9c2afb", "9c075e65-d450-4682-8df2-167f89178328", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("db26b129-d984-42f7-b9cb-8bd055a07170"), "Roman" },
                    { new Guid("5bfd92a8-617c-42b3-8ae4-e7dc5475b67e"), "Proze" },
                    { new Guid("43ae5db0-92ce-4a6e-82cd-455afbf82bda"), "POezi" },
                    { new Guid("87f7ef59-ecd0-4582-9d20-1da35a66726d"), "Drama" },
                    { new Guid("2be82cce-0537-46bf-b853-bd73a5a21611"), "Biografi" },
                    { new Guid("9258a985-f1f8-4bd1-8e53-3120124fbfb7"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("4213d62d-83de-4228-a4fb-c077207e0af7"), "I Lire" },
                    { new Guid("33034f98-441d-4a8e-9062-49afc01d09bf"), "I dhene" },
                    { new Guid("cee64e37-344a-46d5-85c7-099cbf9e18c2"), "I Demtuar" },
                    { new Guid("30ab17ba-9b49-4024-8146-dcf7db148707"), "I Hequr" },
                    { new Guid("100e1dbe-93f0-46fe-adbd-3efd552bc734"), "I Mbaruar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kerkesat");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44e0acf4-1b4e-4fe2-94da-f1060c9c2afb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "536b5752-a1e0-4f0f-98a6-7ce389b3d7e6");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("2be82cce-0537-46bf-b853-bd73a5a21611"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("43ae5db0-92ce-4a6e-82cd-455afbf82bda"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("5bfd92a8-617c-42b3-8ae4-e7dc5475b67e"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("87f7ef59-ecd0-4582-9d20-1da35a66726d"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("9258a985-f1f8-4bd1-8e53-3120124fbfb7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("db26b129-d984-42f7-b9cb-8bd055a07170"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("100e1dbe-93f0-46fe-adbd-3efd552bc734"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("30ab17ba-9b49-4024-8146-dcf7db148707"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("33034f98-441d-4a8e-9062-49afc01d09bf"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("4213d62d-83de-4228-a4fb-c077207e0af7"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("cee64e37-344a-46d5-85c7-099cbf9e18c2"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e7c1c477-43c3-49fc-9d5a-ce67facd06db", "455ef575-3253-4c54-b53e-a236ca38f607", "Menaxher", "Menaxher" },
                    { "754f95b9-809b-4ffd-bed3-87f263a0e5d3", "bb56a905-9942-41d3-9d49-73abfbdc8bef", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("50fceece-51ff-4f8d-b69d-6ca8bc62da79"), "Roman" },
                    { new Guid("2f3c6ada-7b17-4cfd-ab79-56c189b852c7"), "Proze" },
                    { new Guid("66c851be-52a5-4982-abbe-396ce00f789f"), "POezi" },
                    { new Guid("7b0525d2-0986-4744-b71c-54097e34e5fd"), "Drama" },
                    { new Guid("0bd67ea9-8d27-442d-bc1a-7176664ea2cc"), "Biografi" },
                    { new Guid("471a491f-4144-4966-ad55-404345869a4a"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("b16287e7-31b2-4353-b316-17841cbc71e1"), "I Lire" },
                    { new Guid("9873724d-ced3-4396-863c-704a545a6af6"), "I dhene" },
                    { new Guid("a9ef03d0-30b3-47e5-b374-c4552adfb7d3"), "I Demtuar" },
                    { new Guid("9235c074-69b0-4347-989f-b2cfb0d7420a"), "I Hequr" },
                    { new Guid("b27e94fe-9f90-40a3-a955-4bf3ae860ab0"), "I Mbaruar" }
                });
        }
    }
}

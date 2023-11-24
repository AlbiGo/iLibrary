using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_72 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cd11b43-b549-476b-8b95-78b07e3ab2dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84df455e-ccd3-4912-80be-c34cba3f3e5c");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("2bdd6df3-fe4a-4a3b-a09d-e3a85869e3bd"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("2c37498a-0362-4d47-b036-c1e31b69b2cd"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("3e969c8e-2d79-42e0-a675-555f7a44834b"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("c3f26ffb-e254-4681-bb30-15ed9af577b4"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("c7ee67bc-4e7e-46ac-a351-31cb22ea4cd8"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("de97451c-94a5-4924-9c2a-59c61e583963"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a5d12000-ae4b-4c08-9e33-d8ba4dcbf4f3"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("c8b1c35c-df8a-4c90-873e-6af3a83cce95"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("cf737ab7-af96-4cb2-8746-5b759a42d612"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("d2cbafdc-2490-4b5d-9552-e401dba2a655"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("d9dd972d-0b41-4c66-8790-cae6a830edc1"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DitelindjaLexuesit",
                table: "Kerkesat",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmerLexuesi",
                table: "Kerkesat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MbiemerLexuesi",
                table: "Kerkesat",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "DitelindjaLexuesit",
                table: "Kerkesat");

            migrationBuilder.DropColumn(
                name: "EmerLexuesi",
                table: "Kerkesat");

            migrationBuilder.DropColumn(
                name: "MbiemerLexuesi",
                table: "Kerkesat");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "84df455e-ccd3-4912-80be-c34cba3f3e5c", "f39b8b14-adf5-47ed-a4cc-f7a7950736db", "Menaxher", "Menaxher" },
                    { "5cd11b43-b549-476b-8b95-78b07e3ab2dc", "b835fdd2-5cef-4dd7-b459-0c8c19724b35", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("de97451c-94a5-4924-9c2a-59c61e583963"), "Roman" },
                    { new Guid("2c37498a-0362-4d47-b036-c1e31b69b2cd"), "Proze" },
                    { new Guid("c3f26ffb-e254-4681-bb30-15ed9af577b4"), "POezi" },
                    { new Guid("2bdd6df3-fe4a-4a3b-a09d-e3a85869e3bd"), "Drama" },
                    { new Guid("3e969c8e-2d79-42e0-a675-555f7a44834b"), "Biografi" },
                    { new Guid("c7ee67bc-4e7e-46ac-a351-31cb22ea4cd8"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("a5d12000-ae4b-4c08-9e33-d8ba4dcbf4f3"), "I Lire" },
                    { new Guid("d2cbafdc-2490-4b5d-9552-e401dba2a655"), "I dhene" },
                    { new Guid("c8b1c35c-df8a-4c90-873e-6af3a83cce95"), "I Demtuar" },
                    { new Guid("d9dd972d-0b41-4c66-8790-cae6a830edc1"), "I Hequr" },
                    { new Guid("cf737ab7-af96-4cb2-8746-5b759a42d612"), "I Mbaruar" }
                });
        }
    }
}

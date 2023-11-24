using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_71 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "DataTerheqjes",
                table: "Kerkesat",
                type: "datetime2",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "DataTerheqjes",
                table: "Kerkesat");

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
    }
}

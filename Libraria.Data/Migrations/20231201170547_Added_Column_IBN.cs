using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Libraria.Data.Migrations
{
    /// <inheritdoc />
    public partial class Added_Column_IBN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "257266cf-c0f7-4dca-ab21-a26d479c1584");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6f94f54e-4658-49f0-adcf-070710c66ea8");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("0b7b96ca-81c9-4d79-b6d4-ba9ad7b7f248"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("27f04b79-f802-41c6-98e7-7fb00e43443d"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("6915f76e-d44a-4b32-b3c9-acc44e3722bd"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7c538db1-e5d9-4860-8e65-c98f06c1ea03"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7e1164c3-0d08-475b-8f1e-4c3a97fc0a66"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("dc26aee3-d41d-4719-9e76-44d35c78b091"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("06e5c4af-3ef8-4db1-b5a6-2e4328656ae8"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("58ad7df5-a914-4b8a-9517-556bfaba2cec"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("6fe44ccd-24a3-4e62-9121-f9b30a81d608"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("b38a1444-2a8e-4e67-8a0d-8c20c0266d76"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("bdff6253-716d-46f0-a808-4f6544751dc1"));

            migrationBuilder.AddColumn<string>(
                name: "IBN",
                table: "Librat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1488e3f-1d0b-43e6-9c7e-29482cfd1b89", null, "Menaxher", "Menaxher" },
                    { "deaec24c-5a96-4a43-b46c-542bcb1f0498", null, "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("2b61a726-04d0-4305-8515-3c7755b1dd5b"), "Roman" },
                    { new Guid("5b8d2c16-cf84-4f67-b280-da1009d0aade"), "Biografi" },
                    { new Guid("b693ebae-21ec-4c4b-987d-56e3cc8972d5"), "Histori" },
                    { new Guid("cce82916-d32c-4dd3-ae96-06ae8bf25269"), "Drama" },
                    { new Guid("d6606e15-0b95-4f4f-9bb5-e03ecd643aff"), "Proze" },
                    { new Guid("f5743517-e248-42cd-a72b-3cf221ad813b"), "POezi" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("20663abc-9322-42e1-9576-b1b3b41d0420"), "I dhene" },
                    { new Guid("39aed154-ef31-48e3-bfa7-e235199b463c"), "I Mbaruar" },
                    { new Guid("6763d7e6-3e90-4ec9-8da9-c3c6211a34ac"), "I Demtuar" },
                    { new Guid("6bd430f0-5d5d-49f1-9720-f2a366f1cf33"), "I Hequr" },
                    { new Guid("7d3fa5eb-ee26-4fb7-9c26-dc95db71e7b0"), "I Lire" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a1488e3f-1d0b-43e6-9c7e-29482cfd1b89");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "deaec24c-5a96-4a43-b46c-542bcb1f0498");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("2b61a726-04d0-4305-8515-3c7755b1dd5b"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("5b8d2c16-cf84-4f67-b280-da1009d0aade"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("b693ebae-21ec-4c4b-987d-56e3cc8972d5"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("cce82916-d32c-4dd3-ae96-06ae8bf25269"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("d6606e15-0b95-4f4f-9bb5-e03ecd643aff"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("f5743517-e248-42cd-a72b-3cf221ad813b"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("20663abc-9322-42e1-9576-b1b3b41d0420"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("39aed154-ef31-48e3-bfa7-e235199b463c"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("6763d7e6-3e90-4ec9-8da9-c3c6211a34ac"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("6bd430f0-5d5d-49f1-9720-f2a366f1cf33"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("7d3fa5eb-ee26-4fb7-9c26-dc95db71e7b0"));

            migrationBuilder.DropColumn(
                name: "IBN",
                table: "Librat");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "257266cf-c0f7-4dca-ab21-a26d479c1584", null, "Punonjese Sporteli", "Punonjese Sporteli" },
                    { "6f94f54e-4658-49f0-adcf-070710c66ea8", null, "Menaxher", "Menaxher" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("0b7b96ca-81c9-4d79-b6d4-ba9ad7b7f248"), "POezi" },
                    { new Guid("27f04b79-f802-41c6-98e7-7fb00e43443d"), "Proze" },
                    { new Guid("6915f76e-d44a-4b32-b3c9-acc44e3722bd"), "Biografi" },
                    { new Guid("7c538db1-e5d9-4860-8e65-c98f06c1ea03"), "Drama" },
                    { new Guid("7e1164c3-0d08-475b-8f1e-4c3a97fc0a66"), "Histori" },
                    { new Guid("dc26aee3-d41d-4719-9e76-44d35c78b091"), "Roman" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("06e5c4af-3ef8-4db1-b5a6-2e4328656ae8"), "I Lire" },
                    { new Guid("58ad7df5-a914-4b8a-9517-556bfaba2cec"), "I dhene" },
                    { new Guid("6fe44ccd-24a3-4e62-9121-f9b30a81d608"), "I Mbaruar" },
                    { new Guid("b38a1444-2a8e-4e67-8a0d-8c20c0266d76"), "I Demtuar" },
                    { new Guid("bdff6253-716d-46f0-a808-4f6544751dc1"), "I Hequr" }
                });
        }
    }
}

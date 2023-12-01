using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Libraria.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration_30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "25d5d763-7e3a-403a-aa91-73bc7ccbb3ce");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b0680f13-8335-48f4-bd7e-3d7c01bae504");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("0b38ed91-084d-471e-879b-fa2c14f539ba"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("3767dd7d-6733-42c4-9cbc-d38f5d8f69f1"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("41ee4eaf-c98e-4766-ad9d-a743376d7577"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("684d9ee5-5496-4a52-bd3b-2926e54a6cc9"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("813d3ac8-cd78-4d71-8b2d-6e93261e8ec5"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("b2f41687-6b0a-4cbc-a9e6-37f8cfda5d2f"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("76655f25-b6a8-4b06-99c0-1102c0f1d007"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a520f3bd-cc38-49a2-b0ae-90c3488d44c2"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a86e38a2-9743-4ec6-a884-c3d669542185"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("b8a65156-5ce2-4ea1-8ad6-14135e4c9a6a"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("fc327ea8-00b5-45ab-9a51-24cdcb13bb2d"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Datelindja",
                table: "Perdoruesit",
                type: "datetime2",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Datelindja",
                table: "Perdoruesit");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25d5d763-7e3a-403a-aa91-73bc7ccbb3ce", null, "Menaxher", "Menaxher" },
                    { "b0680f13-8335-48f4-bd7e-3d7c01bae504", null, "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("0b38ed91-084d-471e-879b-fa2c14f539ba"), "Roman" },
                    { new Guid("3767dd7d-6733-42c4-9cbc-d38f5d8f69f1"), "Proze" },
                    { new Guid("41ee4eaf-c98e-4766-ad9d-a743376d7577"), "POezi" },
                    { new Guid("684d9ee5-5496-4a52-bd3b-2926e54a6cc9"), "Histori" },
                    { new Guid("813d3ac8-cd78-4d71-8b2d-6e93261e8ec5"), "Biografi" },
                    { new Guid("b2f41687-6b0a-4cbc-a9e6-37f8cfda5d2f"), "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("76655f25-b6a8-4b06-99c0-1102c0f1d007"), "I Hequr" },
                    { new Guid("a520f3bd-cc38-49a2-b0ae-90c3488d44c2"), "I Lire" },
                    { new Guid("a86e38a2-9743-4ec6-a884-c3d669542185"), "I Mbaruar" },
                    { new Guid("b8a65156-5ce2-4ea1-8ad6-14135e4c9a6a"), "I Demtuar" },
                    { new Guid("fc327ea8-00b5-45ab-9a51-24cdcb13bb2d"), "I dhene" }
                });
        }
    }
}

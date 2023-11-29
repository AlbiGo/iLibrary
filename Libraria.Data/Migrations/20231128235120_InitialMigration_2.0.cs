using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Libraria.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration_20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6e36aace-efc3-4bfe-8994-f60403a9dc1e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6ee69be8-d573-4dd0-868b-42f3052dbd87");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("41955450-2339-4d1a-ba0e-f37d0a320944"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("4554120f-0258-43fe-8edd-d7d53904d047"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("9ba95c58-fe04-473a-bd73-86f3a00e4374"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("afa0ee5f-208b-471f-8ccb-656eadc6c0ba"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("ea1b334b-ac60-434c-9bad-0640b521317f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("f6c56402-fc10-4799-9a19-eb0a8d55fbc6"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("05610515-d515-48b0-8486-f2e08d506234"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("38febc94-9e4c-4055-8e2e-0da252518e5b"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("41c5185c-66c0-4495-898a-0dc61c70ef39"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("aa51c7b3-156d-4610-bf40-09481414805d"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("e57abc57-67f4-40d3-accc-9c36436d1e18"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6e36aace-efc3-4bfe-8994-f60403a9dc1e", null, "Menaxher", "Menaxher" },
                    { "6ee69be8-d573-4dd0-868b-42f3052dbd87", null, "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("41955450-2339-4d1a-ba0e-f37d0a320944"), "Histori" },
                    { new Guid("4554120f-0258-43fe-8edd-d7d53904d047"), "Roman" },
                    { new Guid("9ba95c58-fe04-473a-bd73-86f3a00e4374"), "Proze" },
                    { new Guid("afa0ee5f-208b-471f-8ccb-656eadc6c0ba"), "POezi" },
                    { new Guid("ea1b334b-ac60-434c-9bad-0640b521317f"), "Biografi" },
                    { new Guid("f6c56402-fc10-4799-9a19-eb0a8d55fbc6"), "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("05610515-d515-48b0-8486-f2e08d506234"), "I Lire" },
                    { new Guid("38febc94-9e4c-4055-8e2e-0da252518e5b"), "I Demtuar" },
                    { new Guid("41c5185c-66c0-4495-898a-0dc61c70ef39"), "I Hequr" },
                    { new Guid("aa51c7b3-156d-4610-bf40-09481414805d"), "I dhene" },
                    { new Guid("e57abc57-67f4-40d3-accc-9c36436d1e18"), "I Mbaruar" }
                });
        }
    }
}

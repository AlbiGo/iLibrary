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
                keyValue: "a7a8dc2d-d814-4d21-a173-06ea618e607c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d57998af-4451-4b9c-a4d1-d5ea4955c65d");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("0df3455a-a939-4396-8ddb-01ec0d8be141"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("33f767b9-6953-4586-8a36-1b71fb89b2e8"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("65affaae-7019-407e-ab44-2f3bfe134912"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("6a3eccfd-af85-401d-bf79-a00f878ac00d"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7fa25e2e-66a0-4629-b9ad-806abdd6348a"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("c103c557-92a2-4d15-a74f-3ac1b7ccf078"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("0e90c09f-8c2c-4a69-afc2-ba36731193d5"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("2e8f2fb1-9afb-4f9e-b1fe-665f773a7360"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("4ad07d84-787a-4304-b8e9-562cd421f804"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("8a7a073f-d062-4923-90e6-23d1fa020995"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("b684c4a1-68c9-4ac5-8171-9fee51cfbb07"));

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
                    { "c2f60a52-c0cb-4705-87fd-ecb3ea8841d7", null, "Menaxher", "Menaxher" },
                    { "d70e45d8-ed11-41c7-b074-fa9bc12299ab", null, "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("10292dbe-2764-4ea0-a542-b9e82465b102"), "Roman" },
                    { new Guid("430565ae-6c94-4677-9686-d5e5fa33ba69"), "Histori" },
                    { new Guid("432aa2e0-959d-4144-90b0-ab2716479c48"), "Drama" },
                    { new Guid("64798404-90f5-4722-937c-2cc08d0123df"), "Proze" },
                    { new Guid("89d46724-d0d9-4e71-a579-48e1628c74fb"), "Biografi" },
                    { new Guid("fd7dc39e-76fc-4a65-b7b1-245b4377b126"), "POezi" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("03d8ba71-b0ec-4aca-84ce-4f4b2238da2e"), "I Demtuar" },
                    { new Guid("1cfb890c-1b8d-4fad-8d9d-d4aa787194d4"), "I Mbaruar" },
                    { new Guid("3d2ebe4a-7aad-4758-b2fc-455b1989d8bc"), "I dhene" },
                    { new Guid("a777794a-deb1-4f8b-8051-712d3182df8e"), "I Lire" },
                    { new Guid("ceb8b1e5-9244-4d37-b762-ba3fb0695b3b"), "I Hequr" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c2f60a52-c0cb-4705-87fd-ecb3ea8841d7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d70e45d8-ed11-41c7-b074-fa9bc12299ab");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("10292dbe-2764-4ea0-a542-b9e82465b102"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("430565ae-6c94-4677-9686-d5e5fa33ba69"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("432aa2e0-959d-4144-90b0-ab2716479c48"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("64798404-90f5-4722-937c-2cc08d0123df"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("89d46724-d0d9-4e71-a579-48e1628c74fb"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("fd7dc39e-76fc-4a65-b7b1-245b4377b126"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("03d8ba71-b0ec-4aca-84ce-4f4b2238da2e"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("1cfb890c-1b8d-4fad-8d9d-d4aa787194d4"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("3d2ebe4a-7aad-4758-b2fc-455b1989d8bc"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a777794a-deb1-4f8b-8051-712d3182df8e"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("ceb8b1e5-9244-4d37-b762-ba3fb0695b3b"));

            migrationBuilder.DropColumn(
                name: "IBN",
                table: "Librat");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7a8dc2d-d814-4d21-a173-06ea618e607c", null, "Punonjese Sporteli", "Punonjese Sporteli" },
                    { "d57998af-4451-4b9c-a4d1-d5ea4955c65d", null, "Menaxher", "Menaxher" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("0df3455a-a939-4396-8ddb-01ec0d8be141"), "Roman" },
                    { new Guid("33f767b9-6953-4586-8a36-1b71fb89b2e8"), "POezi" },
                    { new Guid("65affaae-7019-407e-ab44-2f3bfe134912"), "Histori" },
                    { new Guid("6a3eccfd-af85-401d-bf79-a00f878ac00d"), "Biografi" },
                    { new Guid("7fa25e2e-66a0-4629-b9ad-806abdd6348a"), "Drama" },
                    { new Guid("c103c557-92a2-4d15-a74f-3ac1b7ccf078"), "Proze" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("0e90c09f-8c2c-4a69-afc2-ba36731193d5"), "I Hequr" },
                    { new Guid("2e8f2fb1-9afb-4f9e-b1fe-665f773a7360"), "I dhene" },
                    { new Guid("4ad07d84-787a-4304-b8e9-562cd421f804"), "I Lire" },
                    { new Guid("8a7a073f-d062-4923-90e6-23d1fa020995"), "I Mbaruar" },
                    { new Guid("b684c4a1-68c9-4ac5-8171-9fee51cfbb07"), "I Demtuar" }
                });
        }
    }
}

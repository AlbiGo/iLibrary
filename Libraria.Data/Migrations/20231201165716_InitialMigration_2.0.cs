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
                keyValue: "258b45af-1c1e-4309-bf12-4d086ae70cce");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5d4293f1-a8d9-4196-b49d-3d08d2623659");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("02f86cc4-5247-49ab-b0a5-d26f12bc8305"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("09325ea8-768a-44c5-bc1a-0a05690d6be0"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("631d8e51-f884-4ee8-b677-158b9133152a"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("908288bd-94b1-4bde-affa-f75dcc6aa74c"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("ad613109-8799-4acd-bde9-455425731924"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("ccc739ac-5a77-4a44-b1b3-7aabe49ef090"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("38789798-a3a6-4d3f-9fb6-3ad66dc4f42b"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("51ddafa2-fa8a-48c5-9bd8-9c01c132d7f0"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("83bb8839-ba42-4fa1-aa61-a7624f29f57b"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("c4949455-9f09-428c-bf68-600ae9519ec3"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("f6599f02-541a-4ddd-b7af-0127d3195349"));

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
                    { "2b0c1d44-21c0-461e-8dfd-3e85799e61d1", null, "Menaxher", "Menaxher" },
                    { "fc9d6401-7085-4a59-bf86-255d08606848", null, "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("11e1d554-bece-40f5-a328-ba3e59b22e4a"), "POezi" },
                    { new Guid("362ceda3-0821-4ff6-aa6d-0b14e0bfa3fe"), "Roman" },
                    { new Guid("6fc55374-0615-4f99-8a0a-a20a1bc66bfd"), "Proze" },
                    { new Guid("d67bd875-9756-4467-acbb-234fba196bd8"), "Biografi" },
                    { new Guid("f05222e0-44b6-44c1-bbfd-afcd9fe97b47"), "Histori" },
                    { new Guid("f9b4868a-a133-4cd5-944f-2e1cfcc202e1"), "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("027c313a-ff72-4920-afbf-215abe054bc8"), "I dhene" },
                    { new Guid("1a12e47d-9791-494b-9808-028b0ae22181"), "I Demtuar" },
                    { new Guid("359a6019-ede6-43f4-bcec-b89af51c67a8"), "I Mbaruar" },
                    { new Guid("5015c9e5-7115-4fa7-aec8-d88c51185f34"), "I Hequr" },
                    { new Guid("7cc29595-4868-4093-bb86-516104cebddf"), "I Lire" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2b0c1d44-21c0-461e-8dfd-3e85799e61d1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fc9d6401-7085-4a59-bf86-255d08606848");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("11e1d554-bece-40f5-a328-ba3e59b22e4a"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("362ceda3-0821-4ff6-aa6d-0b14e0bfa3fe"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("6fc55374-0615-4f99-8a0a-a20a1bc66bfd"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("d67bd875-9756-4467-acbb-234fba196bd8"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("f05222e0-44b6-44c1-bbfd-afcd9fe97b47"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("f9b4868a-a133-4cd5-944f-2e1cfcc202e1"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("027c313a-ff72-4920-afbf-215abe054bc8"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("1a12e47d-9791-494b-9808-028b0ae22181"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("359a6019-ede6-43f4-bcec-b89af51c67a8"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("5015c9e5-7115-4fa7-aec8-d88c51185f34"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("7cc29595-4868-4093-bb86-516104cebddf"));

            migrationBuilder.DropColumn(
                name: "Datelindja",
                table: "Perdoruesit");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "258b45af-1c1e-4309-bf12-4d086ae70cce", null, "Menaxher", "Menaxher" },
                    { "5d4293f1-a8d9-4196-b49d-3d08d2623659", null, "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("02f86cc4-5247-49ab-b0a5-d26f12bc8305"), "Proze" },
                    { new Guid("09325ea8-768a-44c5-bc1a-0a05690d6be0"), "Biografi" },
                    { new Guid("631d8e51-f884-4ee8-b677-158b9133152a"), "POezi" },
                    { new Guid("908288bd-94b1-4bde-affa-f75dcc6aa74c"), "Roman" },
                    { new Guid("ad613109-8799-4acd-bde9-455425731924"), "Histori" },
                    { new Guid("ccc739ac-5a77-4a44-b1b3-7aabe49ef090"), "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("38789798-a3a6-4d3f-9fb6-3ad66dc4f42b"), "I Demtuar" },
                    { new Guid("51ddafa2-fa8a-48c5-9bd8-9c01c132d7f0"), "I dhene" },
                    { new Guid("83bb8839-ba42-4fa1-aa61-a7624f29f57b"), "I Mbaruar" },
                    { new Guid("c4949455-9f09-428c-bf68-600ae9519ec3"), "I Lire" },
                    { new Guid("f6599f02-541a-4ddd-b7af-0127d3195349"), "I Hequr" }
                });
        }
    }
}

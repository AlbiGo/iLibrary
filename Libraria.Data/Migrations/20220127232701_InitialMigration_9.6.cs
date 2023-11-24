using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_96 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cdc4c85-f810-4f83-b55d-c7c6b697b351");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5536c480-072a-4bb8-85ce-edce9c3ea14f");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("97c25aa3-4dcf-4b47-a26a-7cecc24e9b96"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("a4775a0a-0aec-40f2-8168-f74fad1de86c"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("ad8214cd-455e-41b4-a3d3-39b0e2fc5d90"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("b0184d22-d658-4e59-9e72-5282b98eb826"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("b7a0fb4f-5f35-495c-b318-21d580756200"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("f70b4da5-d6b3-4f07-88c1-64425db594d0"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("1b6f6b0f-78af-49d9-9205-ab47e793406b"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("5f99bb83-34d5-41d3-bd7c-38fb1e59efb9"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a7e8d29a-4ace-47fd-858c-9e5e639c6717"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("d55d3ff3-f371-468b-a3d5-7da539d42862"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("e9bdfece-c091-42c9-acbe-32ddcba96790"));

            migrationBuilder.AddColumn<string>(
                name: "test",
                table: "Kerkesat",
                type: "nvarchar(max)",
                nullable: true);

           

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("7e2f9ddf-5142-448e-9ec5-1a1d65fbf9dd"), "Roman" },
                    { new Guid("4c8548e7-4c11-4ad7-a1fe-61acf65fe556"), "Proze" },
                    { new Guid("aabf3876-e741-4f58-9408-292834738635"), "POezi" },
                    { new Guid("ceb131a6-facc-43ba-b028-d4022f33f539"), "Drama" },
                    { new Guid("1b0e7d41-39e1-4ee6-b8c1-4d955eb7454d"), "Biografi" },
                    { new Guid("4b94f678-3905-40f3-b811-23511396ef2d"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("0d324104-0194-493d-a055-daa4fc2878a0"), "I Lire" },
                    { new Guid("0dd75a0a-7e02-4ffa-99ff-4577c222185a"), "I dhene" },
                    { new Guid("e8c84f98-9957-4de9-992b-be48148ddc05"), "I Demtuar" },
                    { new Guid("fc73c6c1-84e2-442a-bb29-43d548566904"), "I Hequr" },
                    { new Guid("57ab73db-0bbb-402e-a174-0fd657f8d1c8"), "I Mbaruar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("1b0e7d41-39e1-4ee6-b8c1-4d955eb7454d"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("4b94f678-3905-40f3-b811-23511396ef2d"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("4c8548e7-4c11-4ad7-a1fe-61acf65fe556"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7e2f9ddf-5142-448e-9ec5-1a1d65fbf9dd"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("aabf3876-e741-4f58-9408-292834738635"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("ceb131a6-facc-43ba-b028-d4022f33f539"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("0d324104-0194-493d-a055-daa4fc2878a0"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("0dd75a0a-7e02-4ffa-99ff-4577c222185a"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("57ab73db-0bbb-402e-a174-0fd657f8d1c8"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("e8c84f98-9957-4de9-992b-be48148ddc05"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("fc73c6c1-84e2-442a-bb29-43d548566904"));

            migrationBuilder.DropColumn(
                name: "test",
                table: "Kerkesat");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5536c480-072a-4bb8-85ce-edce9c3ea14f", "292191d0-bdd1-48b9-bf25-cef0e13837e0", "Menaxher", "Menaxher" },
                    { "4cdc4c85-f810-4f83-b55d-c7c6b697b351", "40bad497-08a6-443d-be07-95fb0b52cde3", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("f70b4da5-d6b3-4f07-88c1-64425db594d0"), "Roman" },
                    { new Guid("b0184d22-d658-4e59-9e72-5282b98eb826"), "Proze" },
                    { new Guid("b7a0fb4f-5f35-495c-b318-21d580756200"), "POezi" },
                    { new Guid("a4775a0a-0aec-40f2-8168-f74fad1de86c"), "Drama" },
                    { new Guid("97c25aa3-4dcf-4b47-a26a-7cecc24e9b96"), "Biografi" },
                    { new Guid("ad8214cd-455e-41b4-a3d3-39b0e2fc5d90"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("5f99bb83-34d5-41d3-bd7c-38fb1e59efb9"), "I Lire" },
                    { new Guid("e9bdfece-c091-42c9-acbe-32ddcba96790"), "I dhene" },
                    { new Guid("d55d3ff3-f371-468b-a3d5-7da539d42862"), "I Demtuar" },
                    { new Guid("a7e8d29a-4ace-47fd-858c-9e5e639c6717"), "I Hequr" },
                    { new Guid("1b6f6b0f-78af-49d9-9205-ab47e793406b"), "I Mbaruar" }
                });
        }
    }
}

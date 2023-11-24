using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_95 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "426ce0f2-6cba-45c3-a956-906c92ce6d00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "941c9e22-65c6-4ead-9e3c-d9d466d4749f");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("57eb6c2c-ff2a-4458-b386-a8efed445bd1"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("5f6abe53-5043-4bfa-bff1-b3490186e486"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("5f92d06d-dbe3-4863-bee3-11732c597650"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7207ebd8-c9c5-4abc-9b99-fd82e64fced9"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("776651da-195c-4ebe-b28b-646219b265ad"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("a68482bf-0aa3-436a-90bc-04fa14c89496"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("518c4df8-8022-4113-b68b-e00279a4b460"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("56151f85-230b-4f1c-8dc2-97e55333b376"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("57590335-f755-42d7-8753-773a463d99dd"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("5ac85abf-df8c-4569-830e-157df365a195"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("e03c24d9-f614-4d0e-af00-e45e0bab9c58"));

            migrationBuilder.AddColumn<Guid>(
                name: "KerksesaPrind",
                table: "Kerkesat",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

         

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

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

            migrationBuilder.DropColumn(
                name: "KerksesaPrind",
                table: "Kerkesat");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "426ce0f2-6cba-45c3-a956-906c92ce6d00", "c01130e5-0d9d-4c33-91a6-a0f16784218a", "Menaxher", "Menaxher" },
                    { "941c9e22-65c6-4ead-9e3c-d9d466d4749f", "70c2ff12-3776-4035-9a53-6271229f39c6", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("7207ebd8-c9c5-4abc-9b99-fd82e64fced9"), "Roman" },
                    { new Guid("5f6abe53-5043-4bfa-bff1-b3490186e486"), "Proze" },
                    { new Guid("776651da-195c-4ebe-b28b-646219b265ad"), "POezi" },
                    { new Guid("57eb6c2c-ff2a-4458-b386-a8efed445bd1"), "Drama" },
                    { new Guid("a68482bf-0aa3-436a-90bc-04fa14c89496"), "Biografi" },
                    { new Guid("5f92d06d-dbe3-4863-bee3-11732c597650"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("56151f85-230b-4f1c-8dc2-97e55333b376"), "I Lire" },
                    { new Guid("518c4df8-8022-4113-b68b-e00279a4b460"), "I dhene" },
                    { new Guid("e03c24d9-f614-4d0e-af00-e45e0bab9c58"), "I Demtuar" },
                    { new Guid("5ac85abf-df8c-4569-830e-157df365a195"), "I Hequr" },
                    { new Guid("57590335-f755-42d7-8753-773a463d99dd"), "I Mbaruar" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d159204-b880-4511-881f-63333d7bf3ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d8e0c82-1bf8-4d1e-8d4d-f9e2d70d0aee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25a4a3f-60b1-4a45-a3d8-5a0416dfa8bb");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("17cb2888-7f28-4d5e-8c35-29a1990d7176"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("2b353964-4d3d-4ed9-b030-2139df1085c0"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("9d8a195a-56c4-40a7-8fc5-aebd6a9eccb7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("a2344b7c-28c0-46cd-93de-bd1946ccd516"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("bebb4bb1-b822-42bc-b7fd-956d2b1d2f30"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("ddc55cad-200f-4492-aab7-251d1846fbc4"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("9c4233cb-a1fe-4678-913d-dc164f57355b"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a183de3e-09b2-47ab-a462-4dde8bf79fd5"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("cdd73af8-1b33-4933-9f0b-87bbda9be680"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("ddd098cb-0733-4e82-a67f-f6718b7f9107"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60053423-fe04-4f31-8d18-8f4ce0a5d761", "b6234206-fc35-4ba2-8249-0f8e991a82a7", "Menaxher", "Menaxher" },
                    { "5bda7b42-fc69-4b82-81fa-f91ad556475c", "56d8f275-aa9c-4be5-831d-14ee85395c5a", "User", "User" },
                    { "a4ae1906-ba39-4a32-be5d-2d8ac5f496ad", "6dc01720-6dfa-4f66-8859-9eacc81f8b19", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("d488239f-eb59-49fa-9f77-d34ada250314"), "Roman" },
                    { new Guid("363b23eb-4a7a-460f-8e08-4c7fed3e6633"), "Proze" },
                    { new Guid("ea75e483-0d91-4ebc-bc14-41d617e9f9d3"), "POezi" },
                    { new Guid("0e52747c-bfe0-4287-9042-6b213637c124"), "Drama" },
                    { new Guid("44364d66-6281-457b-b1c7-6bbefaa69a25"), "Biografi" },
                    { new Guid("2e0472d0-93dc-413c-b102-97af3fe4687e"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("f895cce0-8dbb-4120-92a2-0370ee182993"), "I Ri" },
                    { new Guid("c817f875-ab64-4849-a8f0-f52c6f7b69bd"), "I dhene" },
                    { new Guid("5543a9d3-2f23-442c-af3d-28ededc20ffd"), "I Demtuar" },
                    { new Guid("6b1e7e90-34f7-445b-a581-c66b2a79bd1f"), "I Hequr" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bda7b42-fc69-4b82-81fa-f91ad556475c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60053423-fe04-4f31-8d18-8f4ce0a5d761");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4ae1906-ba39-4a32-be5d-2d8ac5f496ad");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("0e52747c-bfe0-4287-9042-6b213637c124"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("2e0472d0-93dc-413c-b102-97af3fe4687e"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("363b23eb-4a7a-460f-8e08-4c7fed3e6633"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("44364d66-6281-457b-b1c7-6bbefaa69a25"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("d488239f-eb59-49fa-9f77-d34ada250314"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("ea75e483-0d91-4ebc-bc14-41d617e9f9d3"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("5543a9d3-2f23-442c-af3d-28ededc20ffd"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("6b1e7e90-34f7-445b-a581-c66b2a79bd1f"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("c817f875-ab64-4849-a8f0-f52c6f7b69bd"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("f895cce0-8dbb-4120-92a2-0370ee182993"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8d8e0c82-1bf8-4d1e-8d4d-f9e2d70d0aee", "db343e37-b739-4c08-b124-a2a54b218872", "Menaxher", "Menaxher" },
                    { "6d159204-b880-4511-881f-63333d7bf3ce", "dbbc19de-3602-42cd-b9f9-8cf8117351cd", "User", "User" },
                    { "a25a4a3f-60b1-4a45-a3d8-5a0416dfa8bb", "57c9cd95-daaa-483c-ac23-1a804669d448", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("ddc55cad-200f-4492-aab7-251d1846fbc4"), "Roman" },
                    { new Guid("bebb4bb1-b822-42bc-b7fd-956d2b1d2f30"), "Proze" },
                    { new Guid("17cb2888-7f28-4d5e-8c35-29a1990d7176"), "POezi" },
                    { new Guid("a2344b7c-28c0-46cd-93de-bd1946ccd516"), "Drama" },
                    { new Guid("2b353964-4d3d-4ed9-b030-2139df1085c0"), "Biografi" },
                    { new Guid("9d8a195a-56c4-40a7-8fc5-aebd6a9eccb7"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("cdd73af8-1b33-4933-9f0b-87bbda9be680"), "I Ri" },
                    { new Guid("9c4233cb-a1fe-4678-913d-dc164f57355b"), "I dhene" },
                    { new Guid("ddd098cb-0733-4e82-a67f-f6718b7f9107"), "I Demtuar" },
                    { new Guid("a183de3e-09b2-47ab-a462-4dde8bf79fd5"), "I Hequr" }
                });
        }
    }
}

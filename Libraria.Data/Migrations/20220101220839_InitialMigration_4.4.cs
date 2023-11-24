using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ce597c4-e0fb-42b2-a207-733d00d0efeb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92bdc2af-c2f6-41b8-9c6c-49471e6c4699");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1e3015b-8da5-4d0d-ac2f-82388ed8c09b");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("245109b9-5676-4376-a7b2-b764a8655856"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("649c6dfd-54ba-4ddc-ac57-1f98574a167f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("788ed9ab-b180-4232-ba7f-a04866fde64f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("ab543f57-6053-4b23-8393-40b841ae6dcd"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("dbbae162-83a7-459c-a27d-20702e8bc0bc"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("f587a6aa-b8ca-4650-852a-a40265b1ff2e"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("430faf67-6a1a-4db0-b6d1-53b379dba55b"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("6ab92f9c-a18d-46ca-9f5c-4cf95e328ffa"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2ce597c4-e0fb-42b2-a207-733d00d0efeb", "c3fc3a84-0a61-4805-8631-04fd094a988e", "Menaxher", "Menaxher" },
                    { "e1e3015b-8da5-4d0d-ac2f-82388ed8c09b", "d84dd19d-6a75-4d90-9e4f-1592bed7b6de", "User", "User" },
                    { "92bdc2af-c2f6-41b8-9c6c-49471e6c4699", "e9aba5a5-c380-4413-a7c5-98fd9aef296c", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("245109b9-5676-4376-a7b2-b764a8655856"), "Roman" },
                    { new Guid("788ed9ab-b180-4232-ba7f-a04866fde64f"), "Proze" },
                    { new Guid("ab543f57-6053-4b23-8393-40b841ae6dcd"), "POezi" },
                    { new Guid("649c6dfd-54ba-4ddc-ac57-1f98574a167f"), "Drama" },
                    { new Guid("f587a6aa-b8ca-4650-852a-a40265b1ff2e"), "Biografi" },
                    { new Guid("dbbae162-83a7-459c-a27d-20702e8bc0bc"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("430faf67-6a1a-4db0-b6d1-53b379dba55b"), "I Ri" },
                    { new Guid("6ab92f9c-a18d-46ca-9f5c-4cf95e328ffa"), "I dhene" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("5e11f872-9c3b-47a1-9cad-8d8772284d59"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("891967d4-8468-4203-9ddd-ffc59579e94b"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("9d15e8bf-3d08-4108-9a72-57d038840927"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("d00e6f0f-ee3a-4f88-a369-02cc13bae67a"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("d01763e8-95b9-47b7-8791-7a125a58bee8"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("d7b4affd-c4fc-446f-a8e3-b96d8a82cd9e"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("d00e6f0f-ee3a-4f88-a369-02cc13bae67a"), "Roman" },
                    { new Guid("9d15e8bf-3d08-4108-9a72-57d038840927"), "Proze" },
                    { new Guid("d01763e8-95b9-47b7-8791-7a125a58bee8"), "POezi" },
                    { new Guid("891967d4-8468-4203-9ddd-ffc59579e94b"), "Drama" },
                    { new Guid("5e11f872-9c3b-47a1-9cad-8d8772284d59"), "Biografi" },
                    { new Guid("d7b4affd-c4fc-446f-a8e3-b96d8a82cd9e"), "Histori" }
                });
        }
    }
}

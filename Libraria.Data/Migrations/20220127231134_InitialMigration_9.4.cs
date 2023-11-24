using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_94 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bc42717-8704-4223-9cf9-5894d31704b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e19f9f62-9e75-477c-8f1b-dd3794052e05");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("47742662-8960-4a49-b195-d1d5261f337c"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("65d4985c-2da8-497c-a1ef-05af9811c8ea"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("78693a80-3fb7-4b98-9d25-2dbc5dba9e6c"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7bd68253-6f15-49ad-b815-40666bd583f0"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("d8f62828-1b6d-4ed2-bf2a-36657d8aaabb"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("dbb65966-3642-459e-b291-47b1d271f0bc"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("185fbec3-0ffa-41f6-9a2b-1ca58cadceac"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("3093051c-f17c-4468-8265-7e78545289fd"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("8f9ed920-5a96-46ea-a1b3-cc1349327144"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("90b0f1e8-c716-41e6-a50e-f300be9a30ab"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("ba6a8f75-be2a-4b85-84d3-b098f4ff8616"));

         
            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("1d43b729-ccf7-4c58-873f-2f9a6cf9f44b"), "Roman" },
                    { new Guid("b358ed94-9847-4581-ab33-18ea0ef0a155"), "Proze" },
                    { new Guid("51a4edd2-63c0-4111-ae62-e49c9a7164a9"), "POezi" },
                    { new Guid("96b582a9-4843-41f2-8691-1fd9d5e93e93"), "Drama" },
                    { new Guid("9ae88fed-3c46-44da-a499-a4d658441bce"), "Biografi" },
                    { new Guid("eee70661-c031-439b-96ab-61e098aa9090"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("712e969b-295f-41f7-aacc-01f440ee99d8"), "I Lire" },
                    { new Guid("85805399-c31b-4cc0-9692-349f932244d1"), "I dhene" },
                    { new Guid("6786cf02-e2b5-4c13-b1c2-10dd8352c8f6"), "I Demtuar" },
                    { new Guid("24156632-ee29-427f-a448-afe0b585609d"), "I Hequr" },
                    { new Guid("d748da03-49df-4fcf-b228-1585b8fcf27d"), "I Mbaruar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("1d43b729-ccf7-4c58-873f-2f9a6cf9f44b"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("51a4edd2-63c0-4111-ae62-e49c9a7164a9"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("96b582a9-4843-41f2-8691-1fd9d5e93e93"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("9ae88fed-3c46-44da-a499-a4d658441bce"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("b358ed94-9847-4581-ab33-18ea0ef0a155"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("eee70661-c031-439b-96ab-61e098aa9090"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("24156632-ee29-427f-a448-afe0b585609d"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("6786cf02-e2b5-4c13-b1c2-10dd8352c8f6"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("712e969b-295f-41f7-aacc-01f440ee99d8"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("85805399-c31b-4cc0-9692-349f932244d1"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("d748da03-49df-4fcf-b228-1585b8fcf27d"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7bc42717-8704-4223-9cf9-5894d31704b6", "87407dd6-735c-4170-aea4-1ed039aea627", "Menaxher", "Menaxher" },
                    { "e19f9f62-9e75-477c-8f1b-dd3794052e05", "344ef416-3cd8-4fff-bdd0-fcdc614a9daf", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("78693a80-3fb7-4b98-9d25-2dbc5dba9e6c"), "Roman" },
                    { new Guid("d8f62828-1b6d-4ed2-bf2a-36657d8aaabb"), "Proze" },
                    { new Guid("dbb65966-3642-459e-b291-47b1d271f0bc"), "POezi" },
                    { new Guid("65d4985c-2da8-497c-a1ef-05af9811c8ea"), "Drama" },
                    { new Guid("7bd68253-6f15-49ad-b815-40666bd583f0"), "Biografi" },
                    { new Guid("47742662-8960-4a49-b195-d1d5261f337c"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("8f9ed920-5a96-46ea-a1b3-cc1349327144"), "I Lire" },
                    { new Guid("ba6a8f75-be2a-4b85-84d3-b098f4ff8616"), "I dhene" },
                    { new Guid("185fbec3-0ffa-41f6-9a2b-1ca58cadceac"), "I Demtuar" },
                    { new Guid("3093051c-f17c-4468-8265-7e78545289fd"), "I Hequr" },
                    { new Guid("90b0f1e8-c716-41e6-a50e-f300be9a30ab"), "I Mbaruar" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_91 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dc00997-922c-47d1-b01e-6790ade793fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62c3a38a-b877-4638-9479-f6c5b828fea5");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("1033e18f-1c9a-40d2-8caf-e9b42c047908"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("10ee1f38-e167-4c42-a593-bcd680976574"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("380b4591-1fb9-46df-888f-eba2529f6481"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7883782a-01a6-416a-af49-79f039eac0db"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("83705668-98eb-4bc6-a7cc-f191e4aea21d"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("bca3a4c4-bc66-4c77-a092-6bcc9af56ed9"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("57b6a139-4abf-4238-8ca8-0876c6aad17e"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("7367ed12-1bc1-46b5-9a1e-20570e55ef36"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("7a3d387a-9922-4a52-a80e-2719e3cfdf76"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("8b75a946-ff73-4cb2-920a-b8e82beaf981"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("d3019751-a321-4f61-889c-5be7271a16cd"));

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "f0869253-5e1f-45ad-aaba-e11e50f139ba", "74c68cf2-2ba2-4363-a689-f7047330b4bf", "Menaxher", "Menaxher" },
            //        { "e067edea-24a4-4a64-9aaf-6c4b374e8510", "1e42b200-f869-4187-9976-aae55d840452", "Punonjese Sporteli", "Punonjese Sporteli" }
            //    });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("38b88971-48fb-41b7-8725-f35d5b027614"), "Roman" },
                    { new Guid("b926d8d3-6899-4ab9-9802-064b739acb00"), "Proze" },
                    { new Guid("c1eac1e5-e0c6-4b61-b5ae-9883e4f11152"), "POezi" },
                    { new Guid("c18338de-ecd5-4331-8b9a-cb59c79404af"), "Drama" },
                    { new Guid("8f8c0cc0-231f-48d8-97b3-953653f3924a"), "Biografi" },
                    { new Guid("9a485121-894d-4b40-872a-1eaa3f16b712"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("34b8a77a-7a26-4fd1-bf13-471135794526"), "I Lire" },
                    { new Guid("7dde9e8c-d60e-4431-a45c-d372fef6e576"), "I dhene" },
                    { new Guid("81aa9650-9a2b-4c0d-b069-2d2f36c0f309"), "I Demtuar" },
                    { new Guid("c3894276-19b6-4084-b649-1922c8b76cd8"), "I Hequr" },
                    { new Guid("29fd2d0a-85ce-4717-aed1-7d815ce2e16e"), "I Mbaruar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "e067edea-24a4-4a64-9aaf-6c4b374e8510");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "f0869253-5e1f-45ad-aaba-e11e50f139ba");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("38b88971-48fb-41b7-8725-f35d5b027614"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("8f8c0cc0-231f-48d8-97b3-953653f3924a"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("9a485121-894d-4b40-872a-1eaa3f16b712"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("b926d8d3-6899-4ab9-9802-064b739acb00"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("c18338de-ecd5-4331-8b9a-cb59c79404af"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("c1eac1e5-e0c6-4b61-b5ae-9883e4f11152"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("29fd2d0a-85ce-4717-aed1-7d815ce2e16e"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("34b8a77a-7a26-4fd1-bf13-471135794526"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("7dde9e8c-d60e-4431-a45c-d372fef6e576"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("81aa9650-9a2b-4c0d-b069-2d2f36c0f309"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("c3894276-19b6-4084-b649-1922c8b76cd8"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "62c3a38a-b877-4638-9479-f6c5b828fea5", "d03364d3-b935-458d-81e2-24d8fa3a1b92", "Menaxher", "Menaxher" },
                    { "0dc00997-922c-47d1-b01e-6790ade793fe", "4bfcb981-a05b-44ff-9765-a3efae23f4df", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("1033e18f-1c9a-40d2-8caf-e9b42c047908"), "Roman" },
                    { new Guid("83705668-98eb-4bc6-a7cc-f191e4aea21d"), "Proze" },
                    { new Guid("10ee1f38-e167-4c42-a593-bcd680976574"), "POezi" },
                    { new Guid("bca3a4c4-bc66-4c77-a092-6bcc9af56ed9"), "Drama" },
                    { new Guid("380b4591-1fb9-46df-888f-eba2529f6481"), "Biografi" },
                    { new Guid("7883782a-01a6-416a-af49-79f039eac0db"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("57b6a139-4abf-4238-8ca8-0876c6aad17e"), "I Lire" },
                    { new Guid("8b75a946-ff73-4cb2-920a-b8e82beaf981"), "I dhene" },
                    { new Guid("7367ed12-1bc1-46b5-9a1e-20570e55ef36"), "I Demtuar" },
                    { new Guid("d3019751-a321-4f61-889c-5be7271a16cd"), "I Hequr" },
                    { new Guid("7a3d387a-9922-4a52-a80e-2719e3cfdf76"), "I Mbaruar" }
                });
        }
    }
}

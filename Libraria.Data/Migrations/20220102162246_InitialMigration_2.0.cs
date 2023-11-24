using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FotoLibbriUrl",
                table: "Librat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoProfiliURl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KarteLeximiURL",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ded00c1-186b-4732-ae00-57b75ea03bb2", "04b55d9a-51fd-4a76-85b0-5172f2a99cba", "Menaxher", "Menaxher" },
                    { "ea0e9e7b-3b16-44fd-8008-0784e69e7abb", "9016be96-bc56-441c-8b22-8f3f53191732", "User", "User" },
                    { "5bd42f8a-51dd-4f29-9198-7d6dbc36f23a", "96c38082-ee45-4244-82dd-599c1302b2ad", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("91f8a954-4365-4ef5-a108-abeef16b91da"), "Roman" },
                    { new Guid("423e588c-631c-41e9-a5c8-514438109b1e"), "Proze" },
                    { new Guid("7dc97c02-6f20-4bc9-87d3-a27e0fd45de0"), "POezi" },
                    { new Guid("b5b42a00-fb23-4dcf-9f66-e4112a5b2be4"), "Drama" },
                    { new Guid("9505b8be-3388-469f-aa7e-c0e26f8a3c8e"), "Biografi" },
                    { new Guid("cd97c05c-1d5d-4917-8174-323766bd1dac"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("a442d9b6-4510-4cfd-9175-266d7229d10b"), "I Ri" },
                    { new Guid("93e7e9c8-3f18-4bba-9b1c-0c826b0c939b"), "I dhene" },
                    { new Guid("d72ce792-ddad-434b-af54-61873395edd8"), "I Demtuar" },
                    { new Guid("c9c89f62-9bd6-4e41-816d-8323c433d504"), "I Hequr" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ded00c1-186b-4732-ae00-57b75ea03bb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bd42f8a-51dd-4f29-9198-7d6dbc36f23a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea0e9e7b-3b16-44fd-8008-0784e69e7abb");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("423e588c-631c-41e9-a5c8-514438109b1e"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7dc97c02-6f20-4bc9-87d3-a27e0fd45de0"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("91f8a954-4365-4ef5-a108-abeef16b91da"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("9505b8be-3388-469f-aa7e-c0e26f8a3c8e"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("b5b42a00-fb23-4dcf-9f66-e4112a5b2be4"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("cd97c05c-1d5d-4917-8174-323766bd1dac"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("93e7e9c8-3f18-4bba-9b1c-0c826b0c939b"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a442d9b6-4510-4cfd-9175-266d7229d10b"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("c9c89f62-9bd6-4e41-816d-8323c433d504"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("d72ce792-ddad-434b-af54-61873395edd8"));

            migrationBuilder.DropColumn(
                name: "FotoLibbriUrl",
                table: "Librat");

            migrationBuilder.DropColumn(
                name: "FotoProfiliURl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "KarteLeximiURL",
                table: "AspNetUsers");

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
    }
}

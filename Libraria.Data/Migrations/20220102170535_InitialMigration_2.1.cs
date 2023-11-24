using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FotoLibri",
                table: "Librat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Karta",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b4ca99db-1dad-4ee7-a65e-247b0f300c7b", "ea836c0f-659b-461c-987e-71e5aa26f61b", "Menaxher", "Menaxher" },
                    { "8b31a276-5c3e-44eb-a4c8-da43276f8303", "eb6f6294-d0f4-4442-8ff7-8b301459fc3e", "User", "User" },
                    { "78b32227-9bf4-4d5d-8c3c-e9705b010242", "b99a6e0a-7886-4d81-a9f0-3b66fcf5fbcc", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("60d0d971-91dd-43a6-88ff-4051e7b38fea"), "Roman" },
                    { new Guid("8103b3e6-6e7e-4f02-900c-0b900efad743"), "Proze" },
                    { new Guid("c6f385c5-3f8f-4c6e-9401-ae1959b732f4"), "POezi" },
                    { new Guid("13109430-df7b-4b72-9cb8-5d1e5c5ec449"), "Drama" },
                    { new Guid("84e2d182-e561-4b11-a634-86c077242c21"), "Biografi" },
                    { new Guid("21526c38-be0e-4c79-b726-d0eb43e60f2f"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("9b39351d-2780-4ca4-8085-028f025808a8"), "I Ri" },
                    { new Guid("ddf8f29b-2705-413f-9994-8380e40b0244"), "I dhene" },
                    { new Guid("d2c934ae-a1df-46b8-bede-f7ef856bc828"), "I Demtuar" },
                    { new Guid("d1f6d556-c60a-4aef-88ad-6d8e04b74c27"), "I Hequr" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78b32227-9bf4-4d5d-8c3c-e9705b010242");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b31a276-5c3e-44eb-a4c8-da43276f8303");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4ca99db-1dad-4ee7-a65e-247b0f300c7b");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("13109430-df7b-4b72-9cb8-5d1e5c5ec449"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("21526c38-be0e-4c79-b726-d0eb43e60f2f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("60d0d971-91dd-43a6-88ff-4051e7b38fea"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("8103b3e6-6e7e-4f02-900c-0b900efad743"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("84e2d182-e561-4b11-a634-86c077242c21"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("c6f385c5-3f8f-4c6e-9401-ae1959b732f4"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("9b39351d-2780-4ca4-8085-028f025808a8"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("d1f6d556-c60a-4aef-88ad-6d8e04b74c27"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("d2c934ae-a1df-46b8-bede-f7ef856bc828"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("ddf8f29b-2705-413f-9994-8380e40b0244"));

            migrationBuilder.DropColumn(
                name: "FotoLibri",
                table: "Librat");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Karta",
                table: "AspNetUsers");

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
    }
}

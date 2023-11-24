using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LIber_Perdorues_AspNetUsers_PerdoruesId",
                table: "LIber_Perdorues");

            migrationBuilder.DropIndex(
                name: "IX_LIber_Perdorues_PerdoruesId",
                table: "LIber_Perdorues");

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
                name: "PerdoruesId",
                table: "LIber_Perdorues");

            migrationBuilder.DropColumn(
                name: "Karta",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "KarteLeximiURL",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Sasia",
                table: "Librat",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LexuesId",
                table: "LIber_Perdorues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Lexuesit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statusi = table.Column<bool>(type: "bit", nullable: true),
                    DataRegj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FotoProfiliURl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KarteLeximiURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Karta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lexuesit", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ea4c6f4f-fdd6-41c1-9cea-5d8b34f11e6f", "0de5e5b1-c3af-42c3-b834-35909bfc41ab", "Menaxher", "Menaxher" },
                    { "c76cd5b5-b300-41e0-ba94-bb791e5e76e0", "cd121704-58af-44a4-b85f-88031907a0e7", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("1a221828-8b04-40cf-a340-33657fbc33d2"), "Roman" },
                    { new Guid("2cd6e80d-47ed-4283-bc01-ad6c0c26b5ce"), "Proze" },
                    { new Guid("b52da0c1-e025-4d65-9c7b-4b4927f73339"), "POezi" },
                    { new Guid("82c60c47-22b6-40a1-b32b-7a466111c785"), "Drama" },
                    { new Guid("6f0df75c-ea14-468f-a34c-d11f27b7c79f"), "Biografi" },
                    { new Guid("c207db34-410c-47fc-86a6-cfe473e2caea"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("dbc73709-ee78-4836-9d6b-abd13e9aa51a"), "I Ri" },
                    { new Guid("3aa5581d-c694-4043-87ce-96f404bbd697"), "I dhene" },
                    { new Guid("db581937-ce22-41ef-a9b2-180addece8d1"), "I Demtuar" },
                    { new Guid("ae315071-1c5d-4d9b-8a8a-844f5e64efb0"), "I Hequr" },
                    { new Guid("aef88522-91fc-48db-b6f0-330803432c26"), "I Mbaruar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LIber_Perdorues_LexuesId",
                table: "LIber_Perdorues",
                column: "LexuesId");

            migrationBuilder.AddForeignKey(
                name: "FK_LIber_Perdorues_Lexuesit_LexuesId",
                table: "LIber_Perdorues",
                column: "LexuesId",
                principalTable: "Lexuesit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LIber_Perdorues_Lexuesit_LexuesId",
                table: "LIber_Perdorues");

            migrationBuilder.DropTable(
                name: "Lexuesit");

            migrationBuilder.DropIndex(
                name: "IX_LIber_Perdorues_LexuesId",
                table: "LIber_Perdorues");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c76cd5b5-b300-41e0-ba94-bb791e5e76e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea4c6f4f-fdd6-41c1-9cea-5d8b34f11e6f");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("1a221828-8b04-40cf-a340-33657fbc33d2"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("2cd6e80d-47ed-4283-bc01-ad6c0c26b5ce"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("6f0df75c-ea14-468f-a34c-d11f27b7c79f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("82c60c47-22b6-40a1-b32b-7a466111c785"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("b52da0c1-e025-4d65-9c7b-4b4927f73339"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("c207db34-410c-47fc-86a6-cfe473e2caea"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("3aa5581d-c694-4043-87ce-96f404bbd697"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("ae315071-1c5d-4d9b-8a8a-844f5e64efb0"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("aef88522-91fc-48db-b6f0-330803432c26"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("db581937-ce22-41ef-a9b2-180addece8d1"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("dbc73709-ee78-4836-9d6b-abd13e9aa51a"));

            migrationBuilder.DropColumn(
                name: "Sasia",
                table: "Librat");

            migrationBuilder.DropColumn(
                name: "LexuesId",
                table: "LIber_Perdorues");

            migrationBuilder.AddColumn<string>(
                name: "PerdoruesId",
                table: "LIber_Perdorues",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Karta",
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

            migrationBuilder.CreateIndex(
                name: "IX_LIber_Perdorues_PerdoruesId",
                table: "LIber_Perdorues",
                column: "PerdoruesId");

            migrationBuilder.AddForeignKey(
                name: "FK_LIber_Perdorues_AspNetUsers_PerdoruesId",
                table: "LIber_Perdorues",
                column: "PerdoruesId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

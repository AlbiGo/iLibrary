using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "AfatiKthimit",
                table: "LIber_Perdorues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ca46e27c-2d76-4de3-b546-f53421366226", "00fe9b4e-43ae-412e-965b-85b2c698261c", "Menaxher", "Menaxher" },
                    { "c9d72347-349c-4903-b0be-0ff5875d3ce3", "c216dda7-ed3c-43da-a13f-d3d588e3f080", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("a44ed0c7-3aa3-4de6-ac73-2ad9a4678461"), "Roman" },
                    { new Guid("d3bac3a1-59a5-421c-a25a-a262ecac5298"), "Proze" },
                    { new Guid("721a459a-cce4-4866-bf8f-21a0e5342c64"), "POezi" },
                    { new Guid("04faa837-dc7c-46f7-a307-ff99636f84db"), "Drama" },
                    { new Guid("73df0f41-ada3-49d5-8c1b-e537d34bcd41"), "Biografi" },
                    { new Guid("02d95d82-e317-458e-87e2-2ac5f41177fe"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("8fae82e8-f9c4-49b8-a342-bde033e4123e"), "I Ri" },
                    { new Guid("a4f7d8c1-f78c-4f91-ad40-2d10af7a2909"), "I dhene" },
                    { new Guid("1abdc249-bd53-4b99-858f-76e5d15856c6"), "I Demtuar" },
                    { new Guid("7b368224-074b-45a3-a7b7-1901f1c06050"), "I Hequr" },
                    { new Guid("770b4232-6ec2-4e85-b677-00a4db6508af"), "I Mbaruar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9d72347-349c-4903-b0be-0ff5875d3ce3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca46e27c-2d76-4de3-b546-f53421366226");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("02d95d82-e317-458e-87e2-2ac5f41177fe"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("04faa837-dc7c-46f7-a307-ff99636f84db"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("721a459a-cce4-4866-bf8f-21a0e5342c64"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("73df0f41-ada3-49d5-8c1b-e537d34bcd41"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("a44ed0c7-3aa3-4de6-ac73-2ad9a4678461"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("d3bac3a1-59a5-421c-a25a-a262ecac5298"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("1abdc249-bd53-4b99-858f-76e5d15856c6"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("770b4232-6ec2-4e85-b677-00a4db6508af"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("7b368224-074b-45a3-a7b7-1901f1c06050"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("8fae82e8-f9c4-49b8-a342-bde033e4123e"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a4f7d8c1-f78c-4f91-ad40-2d10af7a2909"));

            migrationBuilder.DropColumn(
                name: "AfatiKthimit",
                table: "LIber_Perdorues");

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
        }
    }
}

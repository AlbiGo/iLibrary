using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_60 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17a8b53a-3fb8-416a-8d90-bc1de4e18c2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97d98b9d-3f8a-4686-8e25-c0b008f62cf3");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("1d82d060-a7ba-46db-a736-78959604952f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("43aa7528-30e6-42ab-9ba0-c789f382cc0f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("44044d92-578f-42bf-8ad2-34b1a6e1e43b"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("6e9a9e41-0d55-4afe-9f28-a6d9524b4841"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("efe9f2f1-e43f-40c0-80f5-c5c4711d4a69"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("f41042b9-ba82-49ba-9ddc-c253f549941e"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("8200cdfa-4e7a-4266-be22-28476e46c987"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("9482c42d-7245-4364-937f-0fa2ceb5cb0a"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("f08becdd-c6b3-4d17-9408-b84e81fece84"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("f180683e-6035-4838-a01d-93dca8e579a0"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("f84e4cb5-6de3-4f26-8a0d-5071a12ddb75"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataSkadimitTeKartes",
                table: "Lexuesit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e7c1c477-43c3-49fc-9d5a-ce67facd06db", "455ef575-3253-4c54-b53e-a236ca38f607", "Menaxher", "Menaxher" },
                    { "754f95b9-809b-4ffd-bed3-87f263a0e5d3", "bb56a905-9942-41d3-9d49-73abfbdc8bef", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("50fceece-51ff-4f8d-b69d-6ca8bc62da79"), "Roman" },
                    { new Guid("2f3c6ada-7b17-4cfd-ab79-56c189b852c7"), "Proze" },
                    { new Guid("66c851be-52a5-4982-abbe-396ce00f789f"), "POezi" },
                    { new Guid("7b0525d2-0986-4744-b71c-54097e34e5fd"), "Drama" },
                    { new Guid("0bd67ea9-8d27-442d-bc1a-7176664ea2cc"), "Biografi" },
                    { new Guid("471a491f-4144-4966-ad55-404345869a4a"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("b16287e7-31b2-4353-b316-17841cbc71e1"), "I Lire" },
                    { new Guid("9873724d-ced3-4396-863c-704a545a6af6"), "I dhene" },
                    { new Guid("a9ef03d0-30b3-47e5-b374-c4552adfb7d3"), "I Demtuar" },
                    { new Guid("9235c074-69b0-4347-989f-b2cfb0d7420a"), "I Hequr" },
                    { new Guid("b27e94fe-9f90-40a3-a955-4bf3ae860ab0"), "I Mbaruar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "754f95b9-809b-4ffd-bed3-87f263a0e5d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7c1c477-43c3-49fc-9d5a-ce67facd06db");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("0bd67ea9-8d27-442d-bc1a-7176664ea2cc"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("2f3c6ada-7b17-4cfd-ab79-56c189b852c7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("471a491f-4144-4966-ad55-404345869a4a"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("50fceece-51ff-4f8d-b69d-6ca8bc62da79"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("66c851be-52a5-4982-abbe-396ce00f789f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7b0525d2-0986-4744-b71c-54097e34e5fd"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("9235c074-69b0-4347-989f-b2cfb0d7420a"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("9873724d-ced3-4396-863c-704a545a6af6"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a9ef03d0-30b3-47e5-b374-c4552adfb7d3"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("b16287e7-31b2-4353-b316-17841cbc71e1"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("b27e94fe-9f90-40a3-a955-4bf3ae860ab0"));

            migrationBuilder.DropColumn(
                name: "DataSkadimitTeKartes",
                table: "Lexuesit");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "97d98b9d-3f8a-4686-8e25-c0b008f62cf3", "c98dae84-1d75-4cfa-a60e-2c4b096ff881", "Menaxher", "Menaxher" },
                    { "17a8b53a-3fb8-416a-8d90-bc1de4e18c2b", "b2eb121a-6c7c-4e8c-8dcb-caf5e16e56d6", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("43aa7528-30e6-42ab-9ba0-c789f382cc0f"), "Roman" },
                    { new Guid("f41042b9-ba82-49ba-9ddc-c253f549941e"), "Proze" },
                    { new Guid("efe9f2f1-e43f-40c0-80f5-c5c4711d4a69"), "POezi" },
                    { new Guid("6e9a9e41-0d55-4afe-9f28-a6d9524b4841"), "Drama" },
                    { new Guid("1d82d060-a7ba-46db-a736-78959604952f"), "Biografi" },
                    { new Guid("44044d92-578f-42bf-8ad2-34b1a6e1e43b"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("f84e4cb5-6de3-4f26-8a0d-5071a12ddb75"), "I Lire" },
                    { new Guid("f08becdd-c6b3-4d17-9408-b84e81fece84"), "I dhene" },
                    { new Guid("9482c42d-7245-4364-937f-0fa2ceb5cb0a"), "I Demtuar" },
                    { new Guid("8200cdfa-4e7a-4266-be22-28476e46c987"), "I Hequr" },
                    { new Guid("f180683e-6035-4838-a01d-93dca8e579a0"), "I Mbaruar" }
                });
        }
    }
}

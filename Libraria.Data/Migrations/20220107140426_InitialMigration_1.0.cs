using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7003a641-8ee7-4be8-874c-37526df52372");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f822f5c6-c28f-4647-8a5e-47a48309da2f");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("15fdefe7-cccb-4403-8d35-a326e7fe97c8"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("16412132-85ce-40f2-a8a6-1e0ff829a950"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("51c64461-a32c-42e6-9444-e38d12736722"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("62b93f33-68f4-45df-8ecd-7ccd6734120f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("927c69da-359d-4959-9b03-f30b4df2b246"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("dae86bf2-6e11-4d0f-a7b2-8427c7c32bb1"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("0973b9e8-b31e-445c-b226-00eb1d706ff3"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("4f9664d6-d91f-49e4-b9d3-4050d868a0a9"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("b5b2a005-bd9a-43d3-afa0-527edda0f953"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("c0940fed-a939-4751-b672-0d976f4894c5"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("c4e20bba-939c-4359-99e3-e7cfa279b90d"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Datelindja",
                table: "Lexuesit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NmrId",
                table: "Lexuesit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Datelindja",
                table: "Lexuesit");

            migrationBuilder.DropColumn(
                name: "NmrId",
                table: "Lexuesit");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7003a641-8ee7-4be8-874c-37526df52372", "21883588-705d-4e25-9a0b-55e4733ce186", "Menaxher", "Menaxher" },
                    { "f822f5c6-c28f-4647-8a5e-47a48309da2f", "a8e675b5-69f8-44f4-b0e0-0d5b87c22e87", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("16412132-85ce-40f2-a8a6-1e0ff829a950"), "Roman" },
                    { new Guid("15fdefe7-cccb-4403-8d35-a326e7fe97c8"), "Proze" },
                    { new Guid("dae86bf2-6e11-4d0f-a7b2-8427c7c32bb1"), "POezi" },
                    { new Guid("62b93f33-68f4-45df-8ecd-7ccd6734120f"), "Drama" },
                    { new Guid("927c69da-359d-4959-9b03-f30b4df2b246"), "Biografi" },
                    { new Guid("51c64461-a32c-42e6-9444-e38d12736722"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("4f9664d6-d91f-49e4-b9d3-4050d868a0a9"), "I Lire" },
                    { new Guid("0973b9e8-b31e-445c-b226-00eb1d706ff3"), "I dhene" },
                    { new Guid("c0940fed-a939-4751-b672-0d976f4894c5"), "I Demtuar" },
                    { new Guid("c4e20bba-939c-4359-99e3-e7cfa279b90d"), "I Hequr" },
                    { new Guid("b5b2a005-bd9a-43d3-afa0-527edda0f953"), "I Mbaruar" }
                });
        }
    }
}

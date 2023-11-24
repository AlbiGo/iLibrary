using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_53 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45a6b07a-1802-4c16-bd2c-37084bd968d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69789415-d4eb-4966-8a4e-cd1436b2758d");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("0717e8e4-42eb-47b0-8b6d-3cc40b2e48cc"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("32281503-005b-4623-a106-f929409452d9"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("47906819-9820-41eb-82cd-70333f014036"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("5e4e9073-a7db-433d-b31c-0953df6ddaf5"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("89d0d908-a8a9-47af-ae3d-1ed6a8b6a719"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("dfaffe71-d034-4637-b86d-411aff6ee881"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("1b89e230-b2c9-4c1d-8c64-67814efa307c"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("3177d003-02eb-4b6d-8c37-5fd3308a6ab9"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("6a20abd0-8520-4b56-b2ea-cc7ebaad1716"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("dda1b7f8-e1a1-47f1-bbc3-9dacd85da5dc"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("ead5c3df-645f-47d4-b243-5acdf874fca3"));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "LIber_Perdorues",
                type: "bit",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Status",
                table: "LIber_Perdorues");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45a6b07a-1802-4c16-bd2c-37084bd968d6", "675105a1-cf07-4a9f-b73a-c7d524f344b1", "Menaxher", "Menaxher" },
                    { "69789415-d4eb-4966-8a4e-cd1436b2758d", "286805c2-7ebd-4b4b-9d07-7acc2339086c", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("5e4e9073-a7db-433d-b31c-0953df6ddaf5"), "Roman" },
                    { new Guid("dfaffe71-d034-4637-b86d-411aff6ee881"), "Proze" },
                    { new Guid("32281503-005b-4623-a106-f929409452d9"), "POezi" },
                    { new Guid("47906819-9820-41eb-82cd-70333f014036"), "Drama" },
                    { new Guid("0717e8e4-42eb-47b0-8b6d-3cc40b2e48cc"), "Biografi" },
                    { new Guid("89d0d908-a8a9-47af-ae3d-1ed6a8b6a719"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("1b89e230-b2c9-4c1d-8c64-67814efa307c"), "I Ri" },
                    { new Guid("ead5c3df-645f-47d4-b243-5acdf874fca3"), "I dhene" },
                    { new Guid("6a20abd0-8520-4b56-b2ea-cc7ebaad1716"), "I Demtuar" },
                    { new Guid("3177d003-02eb-4b6d-8c37-5fd3308a6ab9"), "I Hequr" },
                    { new Guid("dda1b7f8-e1a1-47f1-bbc3-9dacd85da5dc"), "I Mbaruar" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_50 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28f9b56b-049d-42eb-ac7e-b947f81ea120");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b7fb361-a347-47cb-8a69-2c03c897850c");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("094d484d-7ead-4202-b1ca-89ef98a4aa68"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("4b7aab73-0bb7-4aa6-b225-c0a4ec248714"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("5deae550-6b1c-4c90-9bb2-c70e7af68c58"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("8ae4d231-34ef-4850-b28f-6de4e1ca6d69"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("ad3e1dbe-028a-472f-bbe2-b6f01f340d5f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("d68676b2-5fe2-4f47-b60d-46e4e23958cd"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("26e87b23-dd4c-4a71-9b06-3db00aaadef5"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("3265ab7f-368a-41d3-818e-d59921578725"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("4128e73c-d0ac-4d44-98e9-a3467cc3e7ad"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("7af1be8a-47cf-4323-ae10-b0e67af50aeb"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("f38833c7-1666-4b65-8517-706d7283ffcb"));

            migrationBuilder.DropColumn(
                name: "Sasia",
                table: "Librat");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataPerditesimit",
                table: "Librat",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45b2abf8-2fe5-4675-aa24-21fa57137595", "4fde201b-f4b5-4b4a-ba82-27279f9df1c4", "Menaxher", "Menaxher" },
                    { "05a76f8d-169c-4c86-ae90-d1498f3bd71d", "322afe52-2670-4b22-85bd-5ce880fbe80a", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("d2122ed1-53a0-45a1-8d53-1233d9006625"), "Roman" },
                    { new Guid("0a51a235-a412-4429-9b4b-2695e4e10f88"), "Proze" },
                    { new Guid("508786f6-ff6a-405a-bb5e-c11d6bb6d7e7"), "POezi" },
                    { new Guid("b7b6ae6b-23d0-4eb4-985e-f6093003a40e"), "Drama" },
                    { new Guid("59ea5dfb-8a86-43ab-a999-299210a8fdb8"), "Biografi" },
                    { new Guid("3a8d0a13-bfaf-4f6e-a9d3-283e451a27e7"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("ef49fee9-b1b6-4b42-aded-408ae3d2598e"), "I Ri" },
                    { new Guid("0b4010a1-c3b7-4b4c-bcaf-f0a2b8ee461e"), "I dhene" },
                    { new Guid("94222a4b-6e2a-4c43-8165-35427ff93555"), "I Demtuar" },
                    { new Guid("12140ea9-c9a5-4fdf-9b17-02861eb3974a"), "I Hequr" },
                    { new Guid("a7f87518-fc28-4c29-afd0-c6ebfb7767be"), "I Mbaruar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05a76f8d-169c-4c86-ae90-d1498f3bd71d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45b2abf8-2fe5-4675-aa24-21fa57137595");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("0a51a235-a412-4429-9b4b-2695e4e10f88"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("3a8d0a13-bfaf-4f6e-a9d3-283e451a27e7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("508786f6-ff6a-405a-bb5e-c11d6bb6d7e7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("59ea5dfb-8a86-43ab-a999-299210a8fdb8"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("b7b6ae6b-23d0-4eb4-985e-f6093003a40e"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("d2122ed1-53a0-45a1-8d53-1233d9006625"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("0b4010a1-c3b7-4b4c-bcaf-f0a2b8ee461e"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("12140ea9-c9a5-4fdf-9b17-02861eb3974a"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("94222a4b-6e2a-4c43-8165-35427ff93555"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("a7f87518-fc28-4c29-afd0-c6ebfb7767be"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("ef49fee9-b1b6-4b42-aded-408ae3d2598e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataPerditesimit",
                table: "Librat",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sasia",
                table: "Librat",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28f9b56b-049d-42eb-ac7e-b947f81ea120", "1c36ad9f-fdad-4257-a232-b03e26aad402", "Menaxher", "Menaxher" },
                    { "8b7fb361-a347-47cb-8a69-2c03c897850c", "4980789c-385b-4446-8d1c-d62e3f817e66", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("094d484d-7ead-4202-b1ca-89ef98a4aa68"), "Roman" },
                    { new Guid("4b7aab73-0bb7-4aa6-b225-c0a4ec248714"), "Proze" },
                    { new Guid("ad3e1dbe-028a-472f-bbe2-b6f01f340d5f"), "POezi" },
                    { new Guid("5deae550-6b1c-4c90-9bb2-c70e7af68c58"), "Drama" },
                    { new Guid("8ae4d231-34ef-4850-b28f-6de4e1ca6d69"), "Biografi" },
                    { new Guid("d68676b2-5fe2-4f47-b60d-46e4e23958cd"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("4128e73c-d0ac-4d44-98e9-a3467cc3e7ad"), "I Ri" },
                    { new Guid("3265ab7f-368a-41d3-818e-d59921578725"), "I dhene" },
                    { new Guid("7af1be8a-47cf-4323-ae10-b0e67af50aeb"), "I Demtuar" },
                    { new Guid("26e87b23-dd4c-4a71-9b06-3db00aaadef5"), "I Hequr" },
                    { new Guid("f38833c7-1666-4b65-8517-706d7283ffcb"), "I Mbaruar" }
                });
        }
    }
}

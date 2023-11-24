using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_35 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baec6bea-def0-43e8-84da-37992d510c10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c94fbb4b-c2c2-4bbb-9e15-8cb931799eb9");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("017aca3e-1fce-4a59-b111-5f8c843baf78"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("30baaa61-651d-4500-a18f-e39ff5ac66a3"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("80b6b45d-aa29-49b6-bbc7-364fb5412aa3"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("9aba367c-7855-42cf-9517-29734a74151f"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("9e1e6acb-f78e-4ab8-885a-a12408a324a7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("b78cd81e-a162-464a-979f-9cb00d4aff13"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("14826c95-e937-4eb4-bba7-f752a794f1e9"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("66c0806d-1cbd-4f30-9781-4dc42ede484c"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("72169f93-9374-4f9e-9d8e-f6bcafee4601"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("75edb802-c6da-4301-8068-6837b82529b6"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("9888d08a-5dec-4724-adb4-9344b2480c4a"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "baec6bea-def0-43e8-84da-37992d510c10", "2a0a779a-efda-4d15-9377-3ea6621b22b0", "Menaxher", "Menaxher" },
                    { "c94fbb4b-c2c2-4bbb-9e15-8cb931799eb9", "4b015ee2-e5a3-4bae-9c69-143aedc6ba58", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("017aca3e-1fce-4a59-b111-5f8c843baf78"), "Roman" },
                    { new Guid("9e1e6acb-f78e-4ab8-885a-a12408a324a7"), "Proze" },
                    { new Guid("9aba367c-7855-42cf-9517-29734a74151f"), "POezi" },
                    { new Guid("80b6b45d-aa29-49b6-bbc7-364fb5412aa3"), "Drama" },
                    { new Guid("b78cd81e-a162-464a-979f-9cb00d4aff13"), "Biografi" },
                    { new Guid("30baaa61-651d-4500-a18f-e39ff5ac66a3"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("75edb802-c6da-4301-8068-6837b82529b6"), "I Ri" },
                    { new Guid("72169f93-9374-4f9e-9d8e-f6bcafee4601"), "I dhene" },
                    { new Guid("66c0806d-1cbd-4f30-9781-4dc42ede484c"), "I Demtuar" },
                    { new Guid("14826c95-e937-4eb4-bba7-f752a794f1e9"), "I Hequr" },
                    { new Guid("9888d08a-5dec-4724-adb4-9344b2480c4a"), "I Mbaruar" }
                });
        }
    }
}

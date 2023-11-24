using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_90 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56deda7d-415f-494b-9a5c-9732b9eeb897");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d677183-440e-4606-9dc2-a1a0206be6c7");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("08dfc3e5-af49-4648-bd0f-2a8fcff51fee"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("31a599a2-deb2-4ec3-a8b3-76fd06eea2d7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("359fafc0-8ef8-47f3-8208-e244a51045b7"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("57eba866-d618-4615-91f4-dbe3ab4e7627"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("7b5af2b3-95b1-4e14-a03a-8657d9de0899"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("92b8bf84-d0d4-404b-aad1-24f4cd1ddda1"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("47804644-6f18-45bf-bca6-34d93a207004"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("50955a30-aee8-428f-8451-2faec336512d"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("6539ffee-0e6b-48ff-9fbd-fe4df0e9496c"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("7bddd6f8-4043-4a94-a1f9-2f11ebd0f899"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("8d301399-200c-441e-892c-3b00df171482"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "756cbb31-d1b1-4742-9ffe-50af72491c62", "88b6560f-ea97-403e-9377-a9d451b608ad", "Menaxher", "Menaxher" },
                    { "d2d7c403-2262-4abb-a79a-2c508b114320", "e9335edb-aa0f-43af-bdfe-de2022dd1747", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("61276746-2063-43ac-88ae-a475c2c0cf58"), "Roman" },
                    { new Guid("8e34a420-a6c5-4604-af00-770d2d1ba1ab"), "Proze" },
                    { new Guid("df5600ae-26fe-4058-bb1f-8d6757d3934b"), "POezi" },
                    { new Guid("5f7b5bdb-6bca-475e-8fd1-12a02440e6ea"), "Drama" },
                    { new Guid("cd65c296-ac1c-4e0c-8339-734598f8e0bc"), "Biografi" },
                    { new Guid("c59b51af-6e06-4528-a804-b7a9116eea4a"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("ddfb6f5f-d61e-41cb-90a3-24c5d1176199"), "I Lire" },
                    { new Guid("51fa074c-cf45-4f14-b55c-949982c94349"), "I dhene" },
                    { new Guid("2a3651af-5b4a-46aa-a62f-ca37e4f50499"), "I Demtuar" },
                    { new Guid("71f34aa8-ea74-4473-bd90-4a166e475103"), "I Hequr" },
                    { new Guid("faf6e168-a051-48c4-a2fe-2569e6496dad"), "I Mbaruar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "756cbb31-d1b1-4742-9ffe-50af72491c62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2d7c403-2262-4abb-a79a-2c508b114320");

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("5f7b5bdb-6bca-475e-8fd1-12a02440e6ea"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("61276746-2063-43ac-88ae-a475c2c0cf58"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("8e34a420-a6c5-4604-af00-770d2d1ba1ab"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("c59b51af-6e06-4528-a804-b7a9116eea4a"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("cd65c296-ac1c-4e0c-8339-734598f8e0bc"));

            migrationBuilder.DeleteData(
                table: "Kategorite",
                keyColumn: "ID",
                keyValue: new Guid("df5600ae-26fe-4058-bb1f-8d6757d3934b"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("2a3651af-5b4a-46aa-a62f-ca37e4f50499"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("51fa074c-cf45-4f14-b55c-949982c94349"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("71f34aa8-ea74-4473-bd90-4a166e475103"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("ddfb6f5f-d61e-41cb-90a3-24c5d1176199"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("faf6e168-a051-48c4-a2fe-2569e6496dad"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56deda7d-415f-494b-9a5c-9732b9eeb897", "dbb371e8-284b-4f76-9bd8-4fbbd6e5abab", "Menaxher", "Menaxher" },
                    { "8d677183-440e-4606-9dc2-a1a0206be6c7", "088ea39f-7838-48a0-a688-7a1237f68af1", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Kategorite",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("92b8bf84-d0d4-404b-aad1-24f4cd1ddda1"), "Roman" },
                    { new Guid("359fafc0-8ef8-47f3-8208-e244a51045b7"), "Proze" },
                    { new Guid("7b5af2b3-95b1-4e14-a03a-8657d9de0899"), "POezi" },
                    { new Guid("57eba866-d618-4615-91f4-dbe3ab4e7627"), "Drama" },
                    { new Guid("08dfc3e5-af49-4648-bd0f-2a8fcff51fee"), "Biografi" },
                    { new Guid("31a599a2-deb2-4ec3-a8b3-76fd06eea2d7"), "Histori" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("7bddd6f8-4043-4a94-a1f9-2f11ebd0f899"), "I Lire" },
                    { new Guid("6539ffee-0e6b-48ff-9fbd-fe4df0e9496c"), "I dhene" },
                    { new Guid("8d301399-200c-441e-892c-3b00df171482"), "I Demtuar" },
                    { new Guid("47804644-6f18-45bf-bca6-34d93a207004"), "I Hequr" },
                    { new Guid("50955a30-aee8-428f-8451-2faec336512d"), "I Mbaruar" }
                });
        }
    }
}

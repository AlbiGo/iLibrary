using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "inventari",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LiberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SasiaNeMagazine = table.Column<int>(type: "int", nullable: true),
                    NevojePerFurnuzim = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventari", x => x.ID);
                    table.ForeignKey(
                        name: "FK_inventari_Librat_LiberId",
                        column: x => x.LiberId,
                        principalTable: "Librat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_inventari_LiberId",
                table: "inventari",
                column: "LiberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inventari");

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
    }
}

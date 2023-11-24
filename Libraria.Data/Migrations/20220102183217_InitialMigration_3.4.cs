using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "AfatiKthimit",
                table: "LIber_Perdorues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AprovuesId",
                table: "LIber_Perdorues",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Aprovuesi",
                table: "LIber_Perdorues",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_LIber_Perdorues_AprovuesId",
                table: "LIber_Perdorues",
                column: "AprovuesId");

            migrationBuilder.AddForeignKey(
                name: "FK_LIber_Perdorues_AspNetUsers_AprovuesId",
                table: "LIber_Perdorues",
                column: "AprovuesId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LIber_Perdorues_AspNetUsers_AprovuesId",
                table: "LIber_Perdorues");

            migrationBuilder.DropIndex(
                name: "IX_LIber_Perdorues_AprovuesId",
                table: "LIber_Perdorues");

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

            migrationBuilder.DropColumn(
                name: "AprovuesId",
                table: "LIber_Perdorues");

            migrationBuilder.DropColumn(
                name: "Aprovuesi",
                table: "LIber_Perdorues");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AfatiKthimit",
                table: "LIber_Perdorues",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
    }
}

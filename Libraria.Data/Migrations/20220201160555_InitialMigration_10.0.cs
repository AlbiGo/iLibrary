using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "Lexuesit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Atesia",
                table: "Lexuesit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Lexuesit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KodiPostar",
                table: "Lexuesit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Memesia",
                table: "Lexuesit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumriId",
                table: "Lexuesit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Qyteti",
                table: "Lexuesit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Universiteti",
                table: "Lexuesit",
                type: "nvarchar(max)",
                nullable: true);

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.DropColumn(
                name: "Adresa",
                table: "Lexuesit");

            migrationBuilder.DropColumn(
                name: "Atesia",
                table: "Lexuesit");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Lexuesit");

            migrationBuilder.DropColumn(
                name: "KodiPostar",
                table: "Lexuesit");

            migrationBuilder.DropColumn(
                name: "Memesia",
                table: "Lexuesit");

            migrationBuilder.DropColumn(
                name: "NumriId",
                table: "Lexuesit");

            migrationBuilder.DropColumn(
                name: "Qyteti",
                table: "Lexuesit");

            migrationBuilder.DropColumn(
                name: "Universiteti",
                table: "Lexuesit");

        }
    }
}

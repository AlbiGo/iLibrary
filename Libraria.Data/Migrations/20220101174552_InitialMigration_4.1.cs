﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraria.Data.Migrations
{
    public partial class InitialMigration_41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ae6d968-0458-4a58-9230-33769b3cd2bf", "5a2ef73b-0646-4285-8366-d39c39659462", "Menaxher", "Menaxher" },
                    { "7c05342c-47af-4540-a43c-92fee430cff3", "a8bd166a-06b3-44de-9c42-1b595576d8b5", "User", "User" },
                    { "ba749917-46f2-4494-b094-8ebc997b8f04", "0e6d383c-3f8e-418a-bd80-0124b52851e2", "Punonjese Sporteli", "Punonjese Sporteli" }
                });

            migrationBuilder.InsertData(
                table: "Statuset",
                columns: new[] { "ID", "Pershkrimi" },
                values: new object[,]
                {
                    { new Guid("c449c281-573a-4393-8a6b-bfef4ef2ffeb"), "I Ri" },
                    { new Guid("c7603859-7611-41ca-93e9-fff76148f00e"), "I dhene" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ae6d968-0458-4a58-9230-33769b3cd2bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c05342c-47af-4540-a43c-92fee430cff3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba749917-46f2-4494-b094-8ebc997b8f04");

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("c449c281-573a-4393-8a6b-bfef4ef2ffeb"));

            migrationBuilder.DeleteData(
                table: "Statuset",
                keyColumn: "ID",
                keyValue: new Guid("c7603859-7611-41ca-93e9-fff76148f00e"));
        }
    }
}
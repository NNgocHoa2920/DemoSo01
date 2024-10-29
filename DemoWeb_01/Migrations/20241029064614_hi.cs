﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DemoWeb_01.Migrations
{
    /// <inheritdoc />
    public partial class hi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Ma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Ma);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Ma", "Description", "Name" },
                values: new object[,]
                {
                    { 1, " trắng", "sắn" },
                    { 2, " trắng", "ngô" },
                    { 3, " trắng", "khoai" },
                    { 4, " trắng", "Bắp" },
                    { 5, " trắng", "dứa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

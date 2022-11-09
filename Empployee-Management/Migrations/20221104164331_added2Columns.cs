﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Empployee_Management.Migrations
{
    public partial class added2Columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Book");
        }
    }
}

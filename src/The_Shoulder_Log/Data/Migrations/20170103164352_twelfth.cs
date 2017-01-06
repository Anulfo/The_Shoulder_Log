using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace The_Shoulder_Log.Data.Migrations
{
    public partial class twelfth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Visit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Visit");
        }
    }
}

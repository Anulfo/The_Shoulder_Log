using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace The_Shoulder_Log.Data.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_AspNetUsers_PhysicianId",
                table: "Visit");

            migrationBuilder.AlterColumn<string>(
                name: "PhysicianId",
                table: "Visit",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_AspNetUsers_PhysicianId",
                table: "Visit",
                column: "PhysicianId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_AspNetUsers_PhysicianId",
                table: "Visit");

            migrationBuilder.AlterColumn<string>(
                name: "PhysicianId",
                table: "Visit",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_AspNetUsers_PhysicianId",
                table: "Visit",
                column: "PhysicianId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

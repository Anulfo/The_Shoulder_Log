using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace The_Shoulder_Log.Data.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_AspNetUsers_PhysicianId",
                table: "Visit");

            migrationBuilder.DropIndex(
                name: "IX_Visit_PhysicianId",
                table: "Visit");

            migrationBuilder.DropColumn(
                name: "PhysicianId",
                table: "Visit");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Visit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "PhysicalTest",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_UserId",
                table: "Visit",
                column: "UserId");

            migrationBuilder.AlterColumn<int>(
                name: "WosiScore",
                table: "ClinicalHist",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_AspNetUsers_UserId",
                table: "Visit",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_AspNetUsers_UserId",
                table: "Visit");

            migrationBuilder.DropIndex(
                name: "IX_Visit_UserId",
                table: "Visit");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Visit");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "PhysicalTest");

            migrationBuilder.AddColumn<string>(
                name: "PhysicianId",
                table: "Visit",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Visit_PhysicianId",
                table: "Visit",
                column: "PhysicianId");

            migrationBuilder.AlterColumn<int>(
                name: "WosiScore",
                table: "ClinicalHist",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_AspNetUsers_PhysicianId",
                table: "Visit",
                column: "PhysicianId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

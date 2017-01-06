using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace The_Shoulder_Log.Data.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "PhysicalTest");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Management");

            migrationBuilder.DropColumn(
                name: "SpadiScore",
                table: "ClinicalHist");

            migrationBuilder.DropColumn(
                name: "WosiScore",
                table: "ClinicalHist");

            migrationBuilder.AddColumn<int>(
                name: "SpadiScoreId",
                table: "Visit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WosiScoreId",
                table: "Visit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpadiScoreId",
                table: "Visit");

            migrationBuilder.DropColumn(
                name: "WosiScoreId",
                table: "Visit");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "PhysicalTest",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Management",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SpadiScore",
                table: "ClinicalHist",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WosiScore",
                table: "ClinicalHist",
                nullable: false,
                defaultValue: 0);
        }
    }
}

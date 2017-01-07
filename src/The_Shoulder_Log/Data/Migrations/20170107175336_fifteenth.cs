using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace The_Shoulder_Log.Data.Migrations
{
    public partial class fifteenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FirstVisit",
                table: "Visit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "TraumaticAntc",
                table: "ClinicalHist",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhysicianComments",
                table: "ClinicalHist",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PainfulShoulder",
                table: "ClinicalHist",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PainActivity",
                table: "ClinicalHist",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstVisit",
                table: "Visit");

            migrationBuilder.AlterColumn<string>(
                name: "TraumaticAntc",
                table: "ClinicalHist",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "PhysicianComments",
                table: "ClinicalHist",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "PainfulShoulder",
                table: "ClinicalHist",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "PainActivity",
                table: "ClinicalHist",
                nullable: false);
        }
    }
}

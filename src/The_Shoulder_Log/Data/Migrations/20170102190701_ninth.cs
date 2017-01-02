using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace The_Shoulder_Log.Data.Migrations
{
    public partial class ninth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "SpadiScore",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CarryingObject",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LyingOnSide",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlacingObjectHighShelf",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PushingArm",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PuttingPants",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PuttingPullover",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PuttingShirtButtons",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reaching",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RemovingBackPocket",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TouchingNeck",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WashingBack",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WashingHair",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorstPain",
                table: "SpadiScore",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "CarryingObject",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "LyingOnSide",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "PlacingObjectHighShelf",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "PushingArm",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "PuttingPants",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "PuttingPullover",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "PuttingShirtButtons",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "Reaching",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "RemovingBackPocket",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "TouchingNeck",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "WashingBack",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "WashingHair",
                table: "SpadiScore");

            migrationBuilder.DropColumn(
                name: "WorstPain",
                table: "SpadiScore");
        }
    }
}

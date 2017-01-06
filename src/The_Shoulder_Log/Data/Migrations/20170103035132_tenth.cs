using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace The_Shoulder_Log.Data.Migrations
{
    public partial class tenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AchingThrobbing",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Compesation",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConsciousSHoulder",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cracking",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DifficultyFitness",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Discomfort",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "WosiScore",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Fatigue",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FearOfFalling",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HorseAround",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LiftObjectsBelow",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OverheadPain",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProtectArm",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RangeOfMotion",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShoulderFrustration",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShoulderWorse",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SleepDifficult",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sports",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SportsOrWork",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stiffness",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weakness",
                table: "WosiScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "WorstPain",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "WashingHair",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "WashingBack",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "TouchingNeck",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "RemovingBackPocket",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "Reaching",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "PuttingShirtButtons",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "PuttingPullover",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "PuttingPants",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "PushingArm",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "PlacingObjectHighShelf",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "LyingOnSide",
                table: "SpadiScore",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "CarryingObject",
                table: "SpadiScore",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AchingThrobbing",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "Compesation",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "ConsciousSHoulder",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "Cracking",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "DifficultyFitness",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "Discomfort",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "Fatigue",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "FearOfFalling",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "HorseAround",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "LiftObjectsBelow",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "OverheadPain",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "ProtectArm",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "RangeOfMotion",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "ShoulderFrustration",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "ShoulderWorse",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "SleepDifficult",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "Sports",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "SportsOrWork",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "Stiffness",
                table: "WosiScore");

            migrationBuilder.DropColumn(
                name: "Weakness",
                table: "WosiScore");

            migrationBuilder.AlterColumn<int>(
                name: "WorstPain",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WashingHair",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WashingBack",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TouchingNeck",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RemovingBackPocket",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Reaching",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PuttingShirtButtons",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PuttingPullover",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PuttingPants",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PushingArm",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlacingObjectHighShelf",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LyingOnSide",
                table: "SpadiScore",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarryingObject",
                table: "SpadiScore",
                nullable: true);
        }
    }
}

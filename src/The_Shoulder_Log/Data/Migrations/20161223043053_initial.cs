using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace The_Shoulder_Log.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClinicalHist",
                columns: table => new
                {
                    ClinicalHistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Allergies = table.Column<string>(nullable: true),
                    FamilyHist = table.Column<string>(nullable: true),
                    HasBeenDislocated = table.Column<bool>(nullable: false),
                    MedicationSummary = table.Column<string>(nullable: true),
                    PainActivity = table.Column<string>(nullable: false),
                    PainDate = table.Column<DateTime>(nullable: false),
                    PainfulShoulder = table.Column<string>(nullable: false),
                    PastMedicalHistory = table.Column<string>(nullable: true),
                    PastSurgeries = table.Column<string>(nullable: true),
                    PhysicianComments = table.Column<string>(nullable: false),
                    SocialHistory = table.Column<string>(nullable: true),
                    SpadiScore = table.Column<int>(nullable: false),
                    TraumaticAntc = table.Column<string>(nullable: false),
                    WosiScore = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicalHist", x => x.ClinicalHistId);
                });

            migrationBuilder.CreateTable(
                name: "Management",
                columns: table => new
                {
                    ManagementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Diagnosis = table.Column<string>(nullable: false),
                    FollowUpStudies = table.Column<string>(nullable: false),
                    Medication = table.Column<string>(nullable: false),
                    Rehabilitation = table.Column<string>(nullable: false),
                    SurgicalTreatment = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Management", x => x.ManagementId);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalTest",
                columns: table => new
                {
                    PhysicalTestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abduction = table.Column<int>(nullable: false),
                    AprehensionTest = table.Column<bool>(nullable: false),
                    DrawerTest = table.Column<bool>(nullable: false),
                    ExternalRotation = table.Column<int>(nullable: false),
                    InternalRotation = table.Column<int>(nullable: false),
                    JobTest = table.Column<bool>(nullable: false),
                    NapoleonTest = table.Column<bool>(nullable: false),
                    SpeedTest = table.Column<bool>(nullable: false),
                    SulcusTest = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalTest", x => x.PhysicalTestId);
                });

            migrationBuilder.CreateTable(
                name: "RegisterPatient",
                columns: table => new
                {
                    RegisterPatientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BloodType = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Height = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: false),
                    Weight = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterPatient", x => x.RegisterPatientId);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    VisitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClinicalHistId = table.Column<int>(nullable: false),
                    ManagementId = table.Column<int>(nullable: false),
                    PhysicalTestId = table.Column<int>(nullable: false),
                    PhysicianId = table.Column<string>(nullable: false),
                    RegisterPatientId = table.Column<int>(nullable: false),
                    VisitDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_Visit_AspNetUsers_PhysicianId",
                        column: x => x.PhysicianId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_PhysicianId",
                table: "Visit",
                column: "PhysicianId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ClinicalHist");

            migrationBuilder.DropTable(
                name: "Management");

            migrationBuilder.DropTable(
                name: "PhysicalTest");

            migrationBuilder.DropTable(
                name: "RegisterPatient");

            migrationBuilder.DropTable(
                name: "Visit");
        }
    }
}

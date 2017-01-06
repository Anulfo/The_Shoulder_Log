﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using The_Shoulder_Log.Data;

namespace The_Shoulder_Log.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20161223043053_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.ClinicalHist", b =>
                {
                    b.Property<int>("ClinicalHistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Allergies");

                    b.Property<string>("FamilyHist");

                    b.Property<bool>("HasBeenDislocated");

                    b.Property<string>("MedicationSummary");

                    b.Property<string>("PainActivity")
                        .IsRequired();

                    b.Property<DateTime>("PainDate");

                    b.Property<string>("PainfulShoulder")
                        .IsRequired();

                    b.Property<string>("PastMedicalHistory");

                    b.Property<string>("PastSurgeries");

                    b.Property<string>("PhysicianComments")
                        .IsRequired();

                    b.Property<string>("SocialHistory");

                    b.Property<int>("SpadiScore");

                    b.Property<string>("TraumaticAntc")
                        .IsRequired();

                    b.Property<int?>("WosiScore");

                    b.HasKey("ClinicalHistId");

                    b.ToTable("ClinicalHist");
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.Management", b =>
                {
                    b.Property<int>("ManagementId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Diagnosis")
                        .IsRequired();

                    b.Property<string>("FollowUpStudies")
                        .IsRequired();

                    b.Property<string>("Medication")
                        .IsRequired();

                    b.Property<string>("Rehabilitation")
                        .IsRequired();

                    b.Property<string>("SurgicalTreatment")
                        .IsRequired();

                    b.HasKey("ManagementId");

                    b.ToTable("Management");
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.PhysicalTest", b =>
                {
                    b.Property<int>("PhysicalTestId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Abduction");

                    b.Property<bool>("AprehensionTest");

                    b.Property<bool>("DrawerTest");

                    b.Property<int>("ExternalRotation");

                    b.Property<int>("InternalRotation");

                    b.Property<bool>("JobTest");

                    b.Property<bool>("NapoleonTest");

                    b.Property<bool>("SpeedTest");

                    b.Property<bool>("SulcusTest");

                    b.HasKey("PhysicalTestId");

                    b.ToTable("PhysicalTest");
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.RegisterPatient", b =>
                {
                    b.Property<int>("RegisterPatientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BloodType")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("Height")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("Quantity");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("StreetAddress")
                        .IsRequired();

                    b.Property<string>("Weight")
                        .IsRequired();

                    b.HasKey("RegisterPatientId");

                    b.ToTable("RegisterPatient");
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.Visit", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClinicalHistId");

                    b.Property<int>("ManagementId");

                    b.Property<int>("PhysicalTestId");

                    b.Property<string>("PhysicianId")
                        .IsRequired();

                    b.Property<int>("RegisterPatientId");

                    b.Property<DateTime>("VisitDate")
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("VisitId");

                    b.HasIndex("PhysicianId");

                    b.ToTable("Visit");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("The_Shoulder_Log.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("The_Shoulder_Log.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("The_Shoulder_Log.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.Visit", b =>
                {
                    b.HasOne("The_Shoulder_Log.Models.ApplicationUser", "Physician")
                        .WithMany("Visits")
                        .HasForeignKey("PhysicianId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

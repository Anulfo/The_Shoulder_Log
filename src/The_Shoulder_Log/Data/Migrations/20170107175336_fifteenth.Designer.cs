using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using The_Shoulder_Log.Data;

namespace The_Shoulder_Log.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170107175336_fifteenth")]
    partial class fifteenth
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

                    b.Property<string>("UserId");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("UserId");

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

                    b.Property<string>("PainActivity");

                    b.Property<DateTime>("PainDate");

                    b.Property<string>("PainfulShoulder");

                    b.Property<string>("PastMedicalHistory");

                    b.Property<string>("PastSurgeries");

                    b.Property<string>("PhysicianComments");

                    b.Property<string>("SocialHistory");

                    b.Property<string>("TraumaticAntc");

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

            modelBuilder.Entity("The_Shoulder_Log.Models.SpadiScore", b =>
                {
                    b.Property<int>("SpadiScoreId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarryingObject");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("LyingOnSide");

                    b.Property<int>("PlacingObjectHighShelf");

                    b.Property<int>("PushingArm");

                    b.Property<int>("PuttingPants");

                    b.Property<int>("PuttingPullover");

                    b.Property<int>("PuttingShirtButtons");

                    b.Property<int>("Reaching");

                    b.Property<int>("RemovingBackPocket");

                    b.Property<int>("SpadiFinalScore");

                    b.Property<int>("TouchingNeck");

                    b.Property<int>("WashingBack");

                    b.Property<int>("WashingHair");

                    b.Property<int>("WorstPain");

                    b.HasKey("SpadiScoreId");

                    b.ToTable("SpadiScore");

                    b.HasDiscriminator<string>("Discriminator").HasValue("SpadiScore");
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.Visit", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClinicalHistId");

                    b.Property<bool>("FirstVisit");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ManagementId");

                    b.Property<int>("PhysicalTestId");

                    b.Property<int>("RegisterPatientId");

                    b.Property<int>("SpadiScoreId");

                    b.Property<string>("UserId");

                    b.Property<DateTime>("VisitDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("WosiScoreId");

                    b.HasKey("VisitId");

                    b.HasIndex("UserId");

                    b.ToTable("Visit");
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.WosiScore", b =>
                {
                    b.Property<int>("WosiScoreId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AchingThrobbing");

                    b.Property<int>("Compesation");

                    b.Property<int>("ConsciousSHoulder");

                    b.Property<int>("Cracking");

                    b.Property<int>("DifficultyFitness");

                    b.Property<int>("Discomfort");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("Fatigue");

                    b.Property<int>("FearOfFalling");

                    b.Property<int>("HorseAround");

                    b.Property<int>("LiftObjectsBelow");

                    b.Property<int>("OverheadPain");

                    b.Property<int>("ProtectArm");

                    b.Property<int>("RangeOfMotion");

                    b.Property<int>("ShoulderFrustration");

                    b.Property<int>("ShoulderWorse");

                    b.Property<int>("SleepDifficult");

                    b.Property<int>("Sports");

                    b.Property<int>("SportsOrWork");

                    b.Property<int>("Stiffness");

                    b.Property<int>("Weakness");

                    b.Property<int>("WosiFinalScore");

                    b.HasKey("WosiScoreId");

                    b.ToTable("WosiScore");

                    b.HasDiscriminator<string>("Discriminator").HasValue("WosiScore");
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.PatientViewModels.PatientSpadiScoreViewModel", b =>
                {
                    b.HasBaseType("The_Shoulder_Log.Models.SpadiScore");


                    b.ToTable("PatientSpadiScoreViewModel");

                    b.HasDiscriminator().HasValue("PatientSpadiScoreViewModel");
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.PatientViewModels.PatientWosiScoreViewModel", b =>
                {
                    b.HasBaseType("The_Shoulder_Log.Models.WosiScore");


                    b.ToTable("PatientWosiScoreViewModel");

                    b.HasDiscriminator().HasValue("PatientWosiScoreViewModel");
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

            modelBuilder.Entity("The_Shoulder_Log.Models.ApplicationUser", b =>
                {
                    b.HasOne("The_Shoulder_Log.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("The_Shoulder_Log.Models.Visit", b =>
                {
                    b.HasOne("The_Shoulder_Log.Models.ApplicationUser", "User")
                        .WithMany("Visits")
                        .HasForeignKey("UserId");
                });
        }
    }
}

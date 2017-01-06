using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Shoulder_Log.Models;

namespace The_Shoulder_Log.Data
{
    public class DbInitializer
    {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context), null, null, null, null, null);
                var store = new RoleStore<IdentityRole>(context);
                var userstore = new UserStore<ApplicationUser>(context);
                var usermanager = new UserManager<ApplicationUser>(userstore, null, new PasswordHasher<ApplicationUser>(null), null, null, null, null, null, null);

                if (!context.Roles.Any(r => r.Name == "Administrator"))
                {
                    var role = new IdentityRole { Name = "Administrator" };
                    await roleManager.CreateAsync(role);
                }

                //Look for any patient
                if (context.RegisterPatient.Any())
                {
                    return; //DB has been seeded
                }

                var registerPatients = new RegisterPatient[]
               {
                    new RegisterPatient
                    {
                        RegisterPatientId = 1,
                        FirstName = "Anulfo",
                        LastName = "Ordaz",
                        StreetAddress = "Ramsey St. Unit 101",
                        City = "Nashville",
                        State = "Tennessee",
                        DateOfBirth = new DateTime(1981, 8, 2),
                        Gender = "male",
                        Height = "5.6",
                        Weight = "158",
                        BloodType = "A+"
                    },
                    new RegisterPatient
                    {
                        RegisterPatientId = 2,
                        FirstName = "Liz",
                        LastName = "Sanger",
                        StreetAddress = "Ramsey St. Unit 101",
                        City = "Nashville",
                        State = "Tennessee",
                        DateOfBirth = new DateTime (1993, 9, 19, 8, 0 , 0),
                        Gender = "female",
                        Height = "5.7",
                        Weight = "125",
                        BloodType = "O-"
                    },
                    new RegisterPatient
                    {
                        RegisterPatientId = 3,
                        FirstName = "Garrett",
                        LastName = "Vangilder",
                        StreetAddress = "100 Elm Street",
                        City = "Nashville",
                        State = "Tennessee",
                        DateOfBirth = new DateTime (1995, 12, 20, 8, 0 , 0),
                        Gender = "male",
                        Height = "5.7",
                        Weight = "145",
                        BloodType = "O+"
                    },
                    new RegisterPatient
                    {
                        RegisterPatientId = 4,
                        FirstName = "Matt",
                        LastName = "Kraatz",
                        StreetAddress = "742 SW Evergreen Terrace",
                        City = "Nashville",
                        State = "Tennessee",
                        DateOfBirth = new DateTime (1993, 4, 20, 8, 0 , 0),
                        Gender = "male",
                        Height = "6.2",
                        Weight = "200",
                        BloodType = "A-"
                    },
                    new RegisterPatient
                    {
                        RegisterPatientId = 5,
                        FirstName = "Elliot",
                        LastName = "Williams",
                        StreetAddress = "Northeast Flanders Street",
                        City = "Nashville",
                        State = "Tennessee",
                        DateOfBirth = new DateTime (1994, 6, 11, 8, 0 , 0),
                        Gender = "male",
                        Height = "5.7",
                        Weight = "150",
                        BloodType = "A+"
                    },
                    new RegisterPatient
                    {
                        RegisterPatientId = 6,
                        FirstName = "Edgar",
                        LastName = "Barajas",
                        StreetAddress = "Southwest Terwilliger Boulevard",
                        City = "Nashville",
                        State = "Tennessee",
                        DateOfBirth = new DateTime (1990, 5, 19, 8, 0 , 0),
                        Gender = "male",
                        Height = "5.6",
                        Weight = "150",
                        BloodType = "A+"
                    },
                    new RegisterPatient
                    {
                        RegisterPatientId = 7,
                        FirstName = "Fletcher",
                        LastName = "Watson",
                        StreetAddress = "Northwest Quimby Street",
                        City = "Nashville",
                        State = "Tennessee",
                        DateOfBirth = new DateTime (1984, 12, 13, 8, 0 , 0),
                        Gender = "male",
                        Height = "5.7",
                        Weight = "190",
                        BloodType = "O+"
                    },
                    new RegisterPatient
                    {
                        RegisterPatientId = 8,
                        FirstName = "Meg",
                        LastName = "Ducharme",
                        StreetAddress = "Northwest Kearney Street",
                        City = "Nashville",
                        State = "Tennessee",
                        DateOfBirth = new DateTime (1995, 02, 19, 8, 0 , 0),
                        Gender = "female",
                        Height = "5.5",
                        Weight = "140",
                        BloodType = "AB+"
                    },
               };
                context.Database.OpenConnection();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT REGISTERPATIENT ON");

                foreach (RegisterPatient rp in registerPatients)
                {
                    context.RegisterPatient.Add(rp);
                }
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT REGISTERPATIENT OFF");

                var clinicalhistories = new ClinicalHist[]
                {
                    new ClinicalHist
                    {
                        ClinicalHistId = 1,
                        PainfulShoulder = "right",
                        PainDate = new DateTime (2016, 3, 16),
                        PainActivity = "While Sleeping, and when lifting things",
                        TraumaticAntc = "car crash in 2016",
                        HasBeenDislocated = false,
                        PhysicianComments = "35 years old male patient who begin to complain about pain in his right shoulder for 8 months",
                        Allergies = "Bee Sting",
                        PastMedicalHistory = "HBP",
                        PastSurgeries = "Apendicitis",
                        MedicationSummary = "",
                        SocialHistory = "Tobacco, alcohol",
                        FamilyHist = "HBP: Grandfather, DM2: grandfather and grand mother from father's side",
                    },
                    new ClinicalHist
                    {
                        ClinicalHistId = 2,
                        PastMedicalHistory = "No relevant illnesses",
                        PastSurgeries = "",
                        MedicationSummary = "",
                        SocialHistory = "Alcohol occasional",
                        FamilyHist = "HBP: Grandfather, DM2: grandfather and grand mother from father's side",
                        PainfulShoulder = "left",
                        PainDate = new DateTime(2016, 10, 16),
                        PainActivity = "While trying external rotation and abduction of the shoulder",
                        TraumaticAntc = "",
                        HasBeenDislocated = false,
                        PhysicianComments = "23 years old female patient who begin to complain about pain in his right shoulder for 3 months"
                    },
                    new ClinicalHist
                    {
                        ClinicalHistId = 3,
                        PastMedicalHistory = "No relevant illnesses",
                        PastSurgeries = "",
                        MedicationSummary = "",
                        SocialHistory = "No alcohol, no tobacco, no drugs",
                        FamilyHist = "HBP: Mother and father",
                        PainfulShoulder = "left",
                        PainDate = new DateTime(2016, 10, 16),
                        PainActivity = "While trying to reach objects above the head",
                        TraumaticAntc = "",
                        HasBeenDislocated = false,
                        PhysicianComments = "20 years old female patient who begin to complain about pain in his right shoulder for 3 months"
                    },
                    new ClinicalHist
                    {
                        ClinicalHistId = 4,
                        PastMedicalHistory = "No relevant illnesses",
                        PastSurgeries = "",
                        MedicationSummary = "",
                        SocialHistory = "Alcohol occasional",
                        FamilyHist = "Prostate CA: Father. DM: uncle",
                        PainfulShoulder = "both",
                        PainDate = new DateTime(2016, 10, 16),
                        PainActivity = "While sleeping and trying to lift arms above the head",
                        TraumaticAntc = "",
                        HasBeenDislocated = false,
                        PhysicianComments = "34 years old female patient who begin to complain about pain in both shoulders for 3 months"
                    },
                    new ClinicalHist
                    {
                        ClinicalHistId = 5,
                        PastMedicalHistory = "Several Dislocations of the shoulder since 11 years old",
                        PastSurgeries = "",
                        MedicationSummary = "",
                        SocialHistory = "Alcohol on weekends",
                        FamilyHist = "No illnesses",
                        PainfulShoulder = "right",
                        PainDate = new DateTime(2015, 10, 15),
                        PainActivity = "While trying external rotation and abduction of the shoulder",
                        TraumaticAntc = "",
                        HasBeenDislocated = true,
                        PhysicianComments = "22 years old female patient who begin to complain about instability in the right shoulder for a few years"
                    },
                    new ClinicalHist
                    {
                        ClinicalHistId = 6,
                        PastMedicalHistory = "No relevant illnesses",
                        PastSurgeries = "",
                        MedicationSummary = "",
                        SocialHistory = "Alcohol occasional",
                        FamilyHist = "HBP: Grandmother",
                        PainfulShoulder = "right",
                        PainDate = new DateTime(2016, 10, 16),
                        PainActivity = "While trying external rotation and abduction of the shoulder",
                        TraumaticAntc = "",
                        HasBeenDislocated = false,
                        PhysicianComments = "65 years old female patient who begin to complain about pain in his right shoulder for 8 months"
                    },
                    new ClinicalHist
                    {
                        ClinicalHistId = 7,
                        PastMedicalHistory = "No relevant illnesses",
                        PastSurgeries = "",
                        MedicationSummary = "",
                        SocialHistory = "Alcohol occasional",
                        FamilyHist = "DM: Uncle",
                        PainfulShoulder = "right",
                        PainDate = new DateTime(2016, 10, 16),
                        PainActivity = "While sleeping and raise arms above the head",
                        TraumaticAntc = "",
                        HasBeenDislocated = false,
                        PhysicianComments = "54 years old female patient who begin to complain about pain in his right shoulder for 8 months"
                    },
                    new ClinicalHist
                    {
                        ClinicalHistId = 8,
                        PastMedicalHistory = "# shoulder dislocations in the past 3 years",
                        PastSurgeries = "",
                        MedicationSummary = "",
                        SocialHistory = "Alcohol",
                        FamilyHist = "DM2: grandfather and grand mother from father's side",
                        PainfulShoulder = "right",
                        PainDate = new DateTime(2016, 10, 16),
                        PainActivity = "While trying external rotation and abduction of the shoulder",
                        TraumaticAntc = "",
                        HasBeenDislocated = true,
                        PhysicianComments = "21 years old female patient who begin to complain about pain and instability in his right shoulder for 3 months"
                    }
                };

                context.Database.OpenConnection();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT CLINICALHIST ON");

                foreach (ClinicalHist ch in clinicalhistories)
                {
                    context.ClinicalHist.Add(ch);
                }

                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT CLINICALHIST OFF");

                var physicalTests = new PhysicalTest[]
                {
                    new PhysicalTest
                    {
                        PhysicalTestId = 1,
                        ExternalRotation = 20,
                        InternalRotation = 15,
                        Abduction = 90,
                        JobTest = true,
                        SpeedTest = true,
                        NapoleonTest = false,
                        DrawerTest = false,
                        SulcusTest = false,
                        AprehensionTest = false
                    },
                    new PhysicalTest
                    {
                        PhysicalTestId = 2,
                        ExternalRotation = 20,
                        InternalRotation = 15,
                        Abduction = 90,
                        JobTest = true,
                        SpeedTest = true,
                        NapoleonTest = false,
                        DrawerTest = false,
                        SulcusTest = false,
                        AprehensionTest = false
                    },
                    new PhysicalTest
                    {
                        PhysicalTestId = 3,
                        ExternalRotation = 20,
                        InternalRotation = 15,
                        Abduction = 90,
                        JobTest = true,
                        SpeedTest = true,
                        NapoleonTest = false,
                        DrawerTest = false,
                        SulcusTest = false,
                        AprehensionTest = false
                    },
                    new PhysicalTest
                    {
                        PhysicalTestId = 4,
                        ExternalRotation = 20,
                        InternalRotation = 15,
                        Abduction = 90,
                        JobTest = true,
                        SpeedTest = true,
                        NapoleonTest = false,
                        DrawerTest = false,
                        SulcusTest = false,
                        AprehensionTest = false
                    },
                    new PhysicalTest
                    {
                        PhysicalTestId = 5,
                        ExternalRotation = 20,
                        InternalRotation = 15,
                        Abduction = 90,
                        JobTest = true,
                        SpeedTest = true,
                        NapoleonTest = false,
                        DrawerTest = false,
                        SulcusTest = false,
                        AprehensionTest = false
                    },
                    new PhysicalTest
                    {
                        PhysicalTestId = 6,
                        ExternalRotation = 20,
                        InternalRotation = 15,
                        Abduction = 90,
                        JobTest = true,
                        SpeedTest = true,
                        NapoleonTest = false,
                        DrawerTest = false,
                        SulcusTest = false,
                        AprehensionTest = false
                    },
                    new PhysicalTest
                    {
                        PhysicalTestId = 7,
                        ExternalRotation = 20,
                        InternalRotation = 15,
                        Abduction = 90,
                        JobTest = true,
                        SpeedTest = true,
                        NapoleonTest = false,
                        DrawerTest = false,
                        SulcusTest = false,
                        AprehensionTest = false
                    },
                    new PhysicalTest
                    {
                        PhysicalTestId = 8,
                        ExternalRotation = 30,
                        InternalRotation = 15,
                        Abduction = 90,
                        JobTest = false,
                        SpeedTest = true,
                        NapoleonTest = false,
                        DrawerTest = false,
                        SulcusTest = false,
                        AprehensionTest = false
                    }
                };
                context.Database.OpenConnection();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT PHYSICALTEST ON");

                foreach (PhysicalTest pt in physicalTests)
                {
                    context.PhysicalTest.Add(pt);
                }

                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT PHYSICALTEST OFF");

                var managements = new Management[]
                {
                    new Management
                    {
                        ManagementId = 1,
                        Diagnosis = "Rotator cuff tear. LHBT tendinitis.",
                        Medication = "Ketoprofen 100mg every 8 hours for 5 days.",
                        Rehabilitation = "Initiate rehabilitation after 1 week with medication. Functional range exercises, and strengthening deltoid muscle",
                        FollowUpStudies = "",
                        SurgicalTreatment = ""
                    },
                    new Management
                    {
                        ManagementId = 1,
                        Diagnosis = "Rotator cuff tear. LHBT tendinitis.",
                        Medication = "Ketoprofen 100mg every 8 hours for 5 days.",
                        Rehabilitation = "Initiate rehabilitation after 1 week with medication. Functional range exercises, and strengthening deltoid muscle",
                        FollowUpStudies = "",
                        SurgicalTreatment = ""
                    },
                    new Management
                    {
                        ManagementId = 2,
                        Diagnosis = "Rotator cuff tear. LHBT tendinitis.",
                        Medication = "Ketoprofen 100mg every 8 hours for 5 days.",
                        Rehabilitation = "Initiate rehabilitation after 1 week with medication. Functional range exercises, and strengthening deltoid muscle",
                        FollowUpStudies = "",
                        SurgicalTreatment = ""
                    },
                    new Management
                    {
                        ManagementId = 3,
                        Diagnosis = "Rotator cuff tear. LHBT tendinitis.",
                        Medication = "Ketoprofen 100mg every 8 hours for 5 days.",
                        Rehabilitation = "Initiate rehabilitation after 1 week with medication. Functional range exercises, and strengthening deltoid muscle",
                        FollowUpStudies = "",
                        SurgicalTreatment = ""
                    },
                    new Management
                    {
                        ManagementId = 4,
                        Diagnosis = "Rotator cuff tear. LHBT tendinitis.",
                        Medication = "Ketoprofen 100mg every 8 hours for 5 days.",
                        Rehabilitation = "Initiate rehabilitation after 1 week with medication. Functional range exercises, and strengthening deltoid muscle",
                        FollowUpStudies = "",
                        SurgicalTreatment = ""
                    },
                    new Management
                    {
                        ManagementId = 5,
                        Diagnosis = "Rotator cuff tear. LHBT tendinitis.",
                        Medication = "Ketoprofen 100mg every 8 hours for 5 days.",
                        Rehabilitation = "Initiate rehabilitation after 1 week with medication. Functional range exercises, and strengthening deltoid muscle",
                        FollowUpStudies = "",
                        SurgicalTreatment = ""
                    },
                    new Management
                    {
                        ManagementId = 6,
                        Diagnosis = "Rotator cuff tear. LHBT tendinitis.",
                        Medication = "Ketoprofen 100mg every 8 hours for 5 days.",
                        Rehabilitation = "Initiate rehabilitation after 1 week with medication. Functional range exercises, and strengthening deltoid muscle",
                        FollowUpStudies = "",
                        SurgicalTreatment = ""
                    },
                    new Management
                    {
                        ManagementId = 7,
                        Diagnosis = "Anterior Left Shoulder Instability",
                        Medication = "Ketoprofen 100mg every 8 hours for 5 days",
                        Rehabilitation = "Initiate rehabilitation after 1 week with medication. Strengthening of deltoid and pectoralis major muscles",
                        FollowUpStudies = "Shoulder CT scan with intraarticular contrast. Shoulder X rays A-P view, axial view and Y-view",
                        SurgicalTreatment = "To decide after checking results of Shoulder CT"
                    },
                    new Management
                    {
                        ManagementId = 8,
                        Diagnosis = "Anterior Left Shoulder Instability",
                        Medication = "Ketoprofen 100mg every 8 hours for 5 days",
                        Rehabilitation = "Initiate rehabilitation after 1 week with medication. Strengthening of deltoid and pectoralis major muscles",
                        FollowUpStudies = "Shoulder CT scan with intraarticular contrast. Shoulder X rays A-P view, axial view and Y-view",
                        SurgicalTreatment = "To decide after checking results of Shoulder CT"
                    }
                };

                context.Database.OpenConnection();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT MANAGEMENT ON");

                foreach (Management m in managements)
                {
                    context.Management.Add(m);
                }
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT MANAGEMENT OFF");

                var visits = new Visit[]
                {

                    new Visit
                    {
                         VisitId = 1,
                         RegisterPatientId = 1,
                         ClinicalHistId = 1,
                         PhysicalTestId  = 1,
                         VisitDate = new DateTime()
                    },
                    new Visit
                    {
                         VisitId = 2,
                         RegisterPatientId = 2,
                         ClinicalHistId = 2,
                         PhysicalTestId  = 2,
                         VisitDate = new DateTime()
                    },
                    new Visit
                    {
                         VisitId = 3,
                         RegisterPatientId = 3,
                         ClinicalHistId = 3,
                         PhysicalTestId  = 3,
                         VisitDate = new DateTime()
                    },
                    new Visit
                    {
                         VisitId = 4,
                         RegisterPatientId = 4,
                         ClinicalHistId = 4,
                         PhysicalTestId  = 4,
                         VisitDate = new DateTime()
                    },
                    new Visit
                    {
                         VisitId = 5,
                         RegisterPatientId = 5,
                         ClinicalHistId = 5,
                         PhysicalTestId  = 5,
                         VisitDate = new DateTime()
                    },
                    new Visit
                    {
                         VisitId = 6,
                         RegisterPatientId = 6,
                         ClinicalHistId = 6,
                         PhysicalTestId  = 6,
                         VisitDate = new DateTime()
                    },
                    new Visit
                    {
                         VisitId = 7,
                         RegisterPatientId = 7,
                         ClinicalHistId = 7,
                         PhysicalTestId  = 7,
                         VisitDate = new DateTime()
                    },
                    new Visit
                    {
                        VisitId = 8,
                        RegisterPatientId = 8,
                        ClinicalHistId = 8,
                        PhysicalTestId  = 8,
                        VisitDate = new DateTime()                    }
                };

                context.Database.OpenConnection();
                context.Database.ExecuteSqlCommand("SET INSERT_IDENTITY VISIT ON");

                foreach (Visit v in visits)
                {
                    context.Visit.Add(v);
                }

                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET INSERT_IDENTITY VISIT OFF");
            }
        }
    }
}

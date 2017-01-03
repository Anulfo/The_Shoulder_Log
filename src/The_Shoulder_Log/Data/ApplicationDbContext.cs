using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using The_Shoulder_Log.Models;
using The_Shoulder_Log.Models.PatientViewModels;

namespace The_Shoulder_Log.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}
        public DbSet<Visit> Visit { get; set; }
        public DbSet<SpadiScore> SpadiScore { get; set; }
        public DbSet<WosiScore> WosiScore { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<RegisterPatient> RegisterPatient { get; set; }
        public DbSet<PhysicalTest> PhysicalTest { get; set; }
        public DbSet<Management> Management { get; set; }
        public DbSet<ClinicalHist> ClinicalHist{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        } 

        public DbSet<PatientSpadiScoreViewModel> PatientSpadiScoreViewModel { get; set; }

        public DbSet<PatientWosiScoreViewModel> PatientWosiScoreViewModel { get; set; }

    }
}

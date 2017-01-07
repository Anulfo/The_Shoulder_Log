using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace The_Shoulder_Log.Models.PhysicianViewModels
{
    public class FinalReportViewModel
    {

        public RegisterPatient Patient { get; set; }

        public ClinicalHist ClinicHist { get; set; }

        public PhysicalTest PhysicalTest { get; set; }

        public Management Management { get; set; }

        public SpadiScore SpadiScore { get; set; }

        public ApplicationUser Physician { get; set; }
        
        public ClinicalHist FirstClinicalHist { get; set; }

        public Visit CurrentVisit { get; set; }
    }
}

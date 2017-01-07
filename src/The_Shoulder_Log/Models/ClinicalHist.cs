using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_Shoulder_Log.Models
{
    public class ClinicalHist
    {
        [Key]

        public int ClinicalHistId { get; set; }


        public string PainfulShoulder { get; set; }


        public DateTime PainDate { get; set; }


        public string PainActivity { get; set; }


        public string TraumaticAntc { get; set; }


        public bool HasBeenDislocated { get; set; }

        public string PhysicianComments { get; set; }

        public string Allergies { get; set; }

        public string PastMedicalHistory { get; set; }

        public string PastSurgeries { get; set; }

        public string MedicationSummary { get; set; }

        public string SocialHistory { get; set; }

        public string FamilyHist { get; set; }
    }
}

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

        [Required]

        public string PainfulShoulder { get; set; }

        [Required]

        public DateTime? PainDate { get; set; }

        [Required]

        public string PainActivity { get; set; }

        [Required]

        public string TraumaticAntc { get; set; }

        //[Required]

        public bool HasBeenDislocated { get; set; }

        [Required]

        public string PhysicianComments { get; set; }

        public string Allergies { get; set; }

        public string PastMedicalHistory { get; set; }

        public string PastSurgeries { get; set; }

        public string MedicationSummary { get; set; }

        public string SocialHistory { get; set; }

        public string FamilyHist { get; set; }
    }
}

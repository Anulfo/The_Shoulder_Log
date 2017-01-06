using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_Shoulder_Log.Models
{
    public class Management
    {
        [Key]

        public int ManagementId { get; set; }

        [Required]

        public string Diagnosis { get; set; }

        [Required]

        public string Medication { get; set; }

        [Required]

        public string Rehabilitation { get; set; }

        [Required]

        public string FollowUpStudies { get; set; }

        [Required]

        public string SurgicalTreatment { get; set; }
    }
}

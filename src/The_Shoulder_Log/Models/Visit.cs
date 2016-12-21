using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace The_Shoulder_Log.Models
{
    public class Visit
    {
        [Key]

        public int VisitId { get; set; }

        [Required]

        public virtual ApplicationUser Physician { get; set; }

        [Required]

        public int RegisterPatientId { get; set; }

        [Required]

        public int ClinicalHistId { get; set; }

        [Required]

        public int PhysicalTestId { get; set; }

        [Required]

        public int ManagementId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]

        public DateTime VisitDate { get; set; }
    }
}

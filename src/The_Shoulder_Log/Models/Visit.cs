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

        public virtual ApplicationUser User { get; set; }

        public int RegisterPatientId { get; set; }

        public int ClinicalHistId { get; set; }

        public int PhysicalTestId { get; set; }

        public int ManagementId { get; set; }

        public int SpadiScoreId { get; set; }

        public int? WosiScoreId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]

        public DateTime VisitDate { get; set; }
    }
}

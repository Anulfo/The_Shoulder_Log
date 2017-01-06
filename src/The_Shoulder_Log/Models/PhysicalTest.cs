using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_Shoulder_Log.Models
{
    public class PhysicalTest
    {
        [Key]

        public int PhysicalTestId { get; set; }

        [Required]

        public int ExternalRotation { get; set; }

        [Required]

        public int InternalRotation { get; set; }

        [Required]

        public int Abduction { get; set; }

        [Required]

        public bool JobTest { get; set; }

        [Required]

        public bool SpeedTest { get; set; }

        [Required]

        public bool NapoleonTest { get; set; }

        [Required]

        public bool DrawerTest { get; set; }

        [Required]

        public bool SulcusTest { get; set; }

        [Required]

        public bool AprehensionTest { get; set; }
    }
}

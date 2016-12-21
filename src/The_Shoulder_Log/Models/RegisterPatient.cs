using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_Shoulder_Log.Models
{
    public class RegisterPatient
    {
        [Key]

        public int RegisterPatientId { get; set; }

        [Required]

        public string FirstName { get; set; }

        [Required]

        public string LastName { get; set; }

        [Required]

        public string StreetAddress { get; set; }

        [Required]

        public string City { get; set; }

        [Required]

        public string State { get; set; }

        [Required]

        public DateTime DateOfBirth { get; set; }

        [Required]

        public string Gender { get; set; }

        [Required]

        public string Weight { get; set; }

        [Required]

        public string Height { get; set; }

        [Required]

        public string BloodType { get; set; }

        public int Quantity { get; set; }
    }
}

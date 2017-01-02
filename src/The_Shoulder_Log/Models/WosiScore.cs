using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_Shoulder_Log.Models
{
    public class WosiScore
    {
        [Key]
        public int WosiScoreId { get; set; }

        [Required]
        public int WosiFinalScore { get; set; }
    }
}

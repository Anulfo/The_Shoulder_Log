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

        public int OverheadPain { get; set; }

        public int AchingThrobbing { get; set; }

        public int Weakness { get; set; }

        public int Fatigue { get; set; }

        public int Cracking { get; set; }

        public int Stiffness { get; set; }

        public int Discomfort { get; set; }

        public int Compesation { get; set; }

        public int RangeOfMotion { get; set; }

        public int Sports { get; set; }

        public int SportsOrWork { get; set; }

        public int ProtectArm { get; set; }

        public int LiftObjectsBelow { get; set; }

        public int FearOfFalling { get; set; }

        public int DifficultyFitness { get; set; }

        public int HorseAround { get; set; }

        public int SleepDifficult { get; set; }

        public int ConsciousSHoulder { get; set; }

        public int ShoulderWorse { get; set; }

        public int ShoulderFrustration { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace The_Shoulder_Log.Models
{
    public class SpadiScore
    {
        [Key]
        public int SpadiScoreId { get; set; }

        [Required]
        public int SpadiFinalScore { get; set; }

        public int WorstPain { get; set; }

        public int LyingOnSide { get; set; }

        public int Reaching { get; set; }

        public int TouchingNeck { get; set; }

        public int PushingArm { get; set; }

        public int WashingHair { get; set; }

        public int WashingBack { get; set; }

        public int PuttingPullover { get; set; }

        public int PuttingShirtButtons { get; set; }

        public int PuttingPants { get; set; }

        public int PlacingObjectHighShelf { get; set; }

        public int CarryingObject { get; set; }

        public int RemovingBackPocket { get; set; }
    }
}

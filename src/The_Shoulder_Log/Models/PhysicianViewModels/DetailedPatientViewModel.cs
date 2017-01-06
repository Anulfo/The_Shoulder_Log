using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace The_Shoulder_Log.Models.PhysicianViewModels
{
    public class DetailedPatientViewModel
    {
        public List<Visit> Visits { get; set; }

        public List<SpadiScore> SpadiScores { get; set; }

    }
}

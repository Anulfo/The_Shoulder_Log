using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace The_Shoulder_Log.Models.PhysicianViewModels
{
    public class LibraryViewModel
    {
        public List<RegisterPatient> Patients { get; set; }
        public List<Visit> Visits { get; set; }
    }
}

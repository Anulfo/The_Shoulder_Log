using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace The_Shoulder_Log.Models.PatientViewModels
{
    public class PatientRegisterViewModel : RegisterPatient
    {
        public class GenderOptions
        {
            public int GenderId { get; set;}
            public string GenderName { get; set;}
        }
        public List<GenderOptions> GenderList { get; set; }
        public int SelectedGenderId { get; set; }
    }
}

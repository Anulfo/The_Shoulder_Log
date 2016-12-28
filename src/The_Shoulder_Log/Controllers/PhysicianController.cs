using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Shoulder_Log.Models;
using Microsoft.AspNetCore.Identity;
using The_Shoulder_Log.Data;
using The_Shoulder_Log.Models.PhysicianViewModels;

namespace The_Shoulder_Log.Controllers
{
    public class PhysicianController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext context;

        public PhysicianController(UserManager<ApplicationUser> userManager, ApplicationDbContext ctx)
        {
            _userManager = userManager;
            context = ctx;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


        public async Task<IActionResult> Library()
        {
            var physician = await GetCurrentUserAsync();
            string physicianId = physician.Id;
            var model = new LibraryViewModel();

            var doctorsPatients = (from patient in context.RegisterPatient
                                    join visit in context.Visit on patient.RegisterPatientId equals visit.RegisterPatientId
                                    where User.Identity == physician
                                    select new RegisterPatient
                                         {
                                             RegisterPatientId = patient.RegisterPatientId,
                                             LastName = patient.LastName,
                                             FirstName = patient.FirstName,
                                             StreetAddress = patient.StreetAddress,
                                             City = patient.City,
                                             State = patient.State,
                                             DateOfBirth = patient.DateOfBirth,
                                             Gender = patient.Gender,
                                             Weight = patient.Weight,
                                             Height = patient.Height,
                                             BloodType = patient.BloodType,
                                             Quantity = patient.Quantity
                                         }).ToList();

            model.Patients = doctorsPatients.ToList();
            return View(model);
        }

        public void CalculateNumberOfVisits(RegisterPatient registerPatient)
        {
            int Quantity = context.Visit.Count();
            registerPatient.Quantity = Quantity;

        }
    }
}
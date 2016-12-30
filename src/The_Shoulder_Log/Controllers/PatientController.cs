using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Shoulder_Log.Data;
using The_Shoulder_Log.Models;
using The_Shoulder_Log.Models.PatientViewModels;
using static The_Shoulder_Log.Models.PatientViewModels.PatientRegisterViewModel;

namespace The_Shoulder_Log.Controllers
{
    public class PatientController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext context;

        public PatientController(UserManager<ApplicationUser> userManager, ApplicationDbContext ctx)
        {
            _userManager = userManager;
            context = ctx;
        }

        [HttpGet]
        public IActionResult PatientRegister()
        {
            var model = new PatientRegisterViewModel();

            model.GenderList = new List<GenderOptions>
            {
                new GenderOptions {GenderId = 1, GenderName= "male" },
                new GenderOptions {GenderId = 2, GenderName= "female" }
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PatientRegister(RegisterPatient registerPatient)
        {
            if (ModelState.IsValid)
            {
                context.Add(registerPatient);
                await context.SaveChangesAsync();
                return RedirectToAction("Library", new RouteValueDictionary(new { controller = "Physician", action = "Library" }));
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult PatientClinicHist()
        {
            var model = new PatientClinicHistViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PatientClinicHist(ClinicalHist clinicalHist)
        {
            if (ModelState.IsValid)
            {
                context.Add(clinicalHist);
                await context.SaveChangesAsync();
                return RedirectToAction("Library", new RouteValueDictionary(new { controller = "Physician", action = "Library" }));
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult PatientPhysicalTest()
        {
            var model = new PatientPhysicalTestViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> PatientPhysicalTest(PhysicalTest physicalTest)
        {
            if (ModelState.IsValid)
            {
                context.Add(physicalTest);
                await context.SaveChangesAsync();
                return RedirectToAction("Library", new RouteValueDictionary(new { controller = "Physician", action = "Library" }));
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult PatientManagement()
        {
            var model = new PatientManagementViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> PatientManagement(Management management)
        {
            if (ModelState.IsValid)
            {
                context.Add(management);
                await context.SaveChangesAsync();
                return RedirectToAction("Library", new RouteValueDictionary(new { Controller = "Physician", Action = "Library" }));
            }
            else
            {
                return View();
            }
        }
    }
}

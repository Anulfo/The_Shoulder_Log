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

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


        [HttpGet]
        public IActionResult PatientRegister()
        {
            var model = new PatientRegisterViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PatientRegister(RegisterPatient registerPatient)
        {
            var physician = await GetCurrentUserAsync();

            if (ModelState.IsValid)
            {
                context.Add(registerPatient);
                await context.SaveChangesAsync();
                Visit visit = new Visit() { RegisterPatientId = registerPatient.RegisterPatientId, IsActive = true, VisitDate = DateTime.Now, User = physician};
                context.Visit.Add(visit);
                await context.SaveChangesAsync();
                return RedirectToAction("PatientClinicHist", new RouteValueDictionary(new { controller = "Patient", action = "PatientClinicHist" }));
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

                var activeVisit = (from visit in context.Visit
                                   where visit.IsActive == true
                                   select visit).Single();

                activeVisit.ClinicalHistId = clinicalHist.ClinicalHistId;
                context.Update(activeVisit);
                await context.SaveChangesAsync();
                return RedirectToAction("PatientPhysicalTest", new RouteValueDictionary(new { controller = "Patient", action = "PatientPhysicalTest" }));
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

                var activeVisit = (from visit in context.Visit
                                   where visit.IsActive == true
                                   select visit).Single();

                activeVisit.PhysicalTestId = physicalTest.PhysicalTestId;
                context.Update(activeVisit);
                await context.SaveChangesAsync();
                return RedirectToAction("PatientSpadiTest", new RouteValueDictionary(new { controller = "Patient", action = "PatientSpadiTest" }));
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

                var activeVisit = (from visit in context.Visit
                                   where visit.IsActive == true
                                   select visit).Single();

                activeVisit.ManagementId = management.ManagementId;
                activeVisit.IsActive = false;
                context.Update(activeVisit);
                await context.SaveChangesAsync();
                return RedirectToAction("Library", new RouteValueDictionary(new { Controller = "Physician", Action = "Library" }));
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult PatientSpadiTest()
        {
            var model = new PatientSpadiScoreViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> PatientSpadiTest(SpadiScore spadiScore)
        {
            if (ModelState.IsValid)
            {
                spadiScore.SpadiFinalScore = spadiScore.WorstPain + spadiScore.LyingOnSide + spadiScore.Reaching + spadiScore.TouchingNeck + spadiScore.PushingArm + spadiScore.WashingHair + spadiScore.WashingBack + spadiScore.PuttingPants + spadiScore.PuttingPullover + spadiScore.PuttingShirtButtons + spadiScore.PlacingObjectHighShelf + spadiScore.CarryingObject + spadiScore.RemovingBackPocket;
                context.Add(spadiScore);
                await context.SaveChangesAsync();

                var activeVisit = (from visit in context.Visit
                                   where visit.IsActive == true
                                   select visit).Single();

                activeVisit.SpadiScoreId = spadiScore.SpadiScoreId;
                context.Update(activeVisit);
                await context.SaveChangesAsync();
                return RedirectToAction("PatientManagement", new RouteValueDictionary(new { Controller = "Patient", Action = "PatientManagement" }));
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult PatientWosiTest()
        {
            var model = new PatientWosiScoreViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> PatientWosiTest(WosiScore wosiScore)
        {
            if (ModelState.IsValid)
            {
                wosiScore.WosiFinalScore = wosiScore.AchingThrobbing + wosiScore.Compesation + wosiScore.ConsciousSHoulder + wosiScore.Cracking + wosiScore.DifficultyFitness + wosiScore.Discomfort + wosiScore.Fatigue + wosiScore.FearOfFalling + wosiScore.HorseAround + wosiScore.LiftObjectsBelow + wosiScore.OverheadPain + wosiScore.ProtectArm + wosiScore.RangeOfMotion + wosiScore.ShoulderFrustration + wosiScore.ShoulderWorse + wosiScore.SleepDifficult + wosiScore.Sports + wosiScore.SportsOrWork + wosiScore.Stiffness + wosiScore.Weakness;
                context.Add(wosiScore);
                await context.SaveChangesAsync();

                var activeVisit = (from visit in context.Visit
                                   where visit.IsActive == true
                                   select visit).Single();

                activeVisit.SpadiScoreId = wosiScore.WosiScoreId;
                context.Update(activeVisit);
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

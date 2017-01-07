using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Shoulder_Log.Models;
using Microsoft.AspNetCore.Identity;
using The_Shoulder_Log.Data;
using The_Shoulder_Log.Models.PhysicianViewModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Collections;

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
            var model = new LibraryViewModel();

            List<RegisterPatient> doctorPatients = await (from registerPatient in context.RegisterPatient
                                                          join visit in context.Visit on registerPatient.RegisterPatientId equals visit.RegisterPatientId
                                                          where visit.User.Id == physician.Id
                                                          select new RegisterPatient()
                                                          {
                                                              RegisterPatientId = registerPatient.RegisterPatientId,
                                                              LastName = registerPatient.LastName,
                                                              FirstName = registerPatient.FirstName,
                                                              StreetAddress = registerPatient.StreetAddress,
                                                              City = registerPatient.City,
                                                              State = registerPatient.State,
                                                              DateOfBirth = registerPatient.DateOfBirth,
                                                              Gender = registerPatient.Gender,
                                                              Weight = registerPatient.Weight,
                                                              Height = registerPatient.Height,
                                                              BloodType = registerPatient.BloodType,
                                                              Quantity = registerPatient.Quantity
                                                          }
                                  ).Distinct().ToListAsync();

            model.Patients = doctorPatients;

            return View(model);
        }

        public async Task<IActionResult> DetailedPatient(int? id)
        {
            var physician = await GetCurrentUserAsync();
            var model = new DetailedPatientViewModel();

            List<Visit> Visits = await (from visit in context.Visit
                                             join registerPatient in context.RegisterPatient on visit.RegisterPatientId equals registerPatient.RegisterPatientId
                                             where registerPatient.RegisterPatientId == id
                                             select visit).ToListAsync();

            model.Visits = Visits;

            List<SpadiScore> SpadiScores = await (from spadiScore in context.SpadiScore
                                                  join visit in context.Visit on spadiScore.SpadiScoreId equals visit.SpadiScoreId
                                                  join registerPatient in context.RegisterPatient on visit.RegisterPatientId equals registerPatient.RegisterPatientId
                                                  where registerPatient.RegisterPatientId == id
                                                  select spadiScore).ToListAsync();

            model.SpadiScores = SpadiScores;

            return View(model);
        }

        public async Task<IActionResult> FinalReport (int? id)
        {
            var phisician = await GetCurrentUserAsync();
            var model = new FinalReportViewModel();

            model.Physician = phisician;

            var patient = await (from pcte in context.RegisterPatient
                                 join visit in context.Visit on pcte.RegisterPatientId equals visit.RegisterPatientId
                                 where visit.VisitId == id
                                 select pcte).SingleOrDefaultAsync();

            model.Patient = patient;
            var currentVisit = await (from visit in context.Visit
                                      where visit.VisitId == id
                                      select visit).SingleOrDefaultAsync();

            model.CurrentVisit = currentVisit;

            var visits = await (from visit in context.Visit
                                    join registerPatient in context.RegisterPatient on visit.RegisterPatientId equals registerPatient.RegisterPatientId
                                    where registerPatient.RegisterPatientId == patient.RegisterPatientId
                                    select visit).ToListAsync();

            var firstVisit = visits.Min(x => x.VisitId);


            var firstClinicHist = await (from clinic in context.ClinicalHist
                                         join visit in context.Visit on clinic.ClinicalHistId equals visit.ClinicalHistId
                                         where visit.VisitId == firstVisit
                                         select clinic).SingleOrDefaultAsync();

            model.FirstClinicalHist = firstClinicHist;
            //Variable to store PhysicianComments from the model, to pass to the view and display it as the Clinical History

            ClinicalHist clinicHist = await (from clinic in context.ClinicalHist
                                    join visit in context.Visit on clinic.ClinicalHistId equals visit.ClinicalHistId
                                    where visit.VisitId == id
                                    select clinic).SingleOrDefaultAsync();
            model.ClinicHist = clinicHist;

            PhysicalTest physicalTest = await (from physicalTes in context.PhysicalTest
                                      join visit in context.Visit on physicalTes.PhysicalTestId equals visit.PhysicalTestId
                                      where visit.VisitId == id
                                      select physicalTes).SingleOrDefaultAsync();

            model.PhysicalTest = physicalTest;



            Management management = await (from mng in context.Management
                                    join visit in context.Visit on mng.ManagementId equals visit.ManagementId
                                    where visit.VisitId == id
                                    select mng).SingleOrDefaultAsync();

            model.Management = management;

            SpadiScore spadiScore = await (from spadiscor in context.SpadiScore
                                    join visit in context.Visit on spadiscor.SpadiScoreId equals visit.SpadiScoreId
                                    where visit.VisitId == id
                                    select spadiscor).SingleOrDefaultAsync();

            model.SpadiScore = spadiScore;

            return View(model);


        }
        public void CalculateNumberOfVisits(RegisterPatient registerPatient)
        {
            int Quantity = context.Visit.Count();
            registerPatient.Quantity = Quantity;

        }
    }
}
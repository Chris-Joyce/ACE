using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeTrackingSystem.Data;
using EmployeeTrackingSystem.Models;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeTrackingSystem.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employee.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        [Authorize(Roles = "Admin, Manager")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Title,Address,City,State,Zip,Phone,DateOfBirth,HireDate,LicenseNumber,CBHT,APDSupportedLiving,APDSupportedEmployement,DCFHippastartDate,DCFHippaEndDate,VehicleRegistrationStartDate,VehicleRegistrationEndDate,VehicleInsuranceCardStartDate,VehicleInsuranceCardEndDate,YearlyEvaluationStartDate,YearlyEvaluationEndDate,TargetCaseManagmentStartDate,TargetCaseManagmentEndDate,AffidavitOfGoodMoralCharacterStartDate,AffidavitOfGoodMoralCharacterEndDate,FDLEBGSStartDate,FDLEBGSEndDate,JSOLocalBGSStartDate,JSOLocalBGSEndDate,ANRPStartDate,ANRPEndDate,ClinicalCompetenceStartDate,ClinicalCompetenceEndDate,ClientPersonalSafetyStartDate,ClientPersonalSafetyEndDate,PatientConfidentialityStartDate,PatientConfidentialityEndDate,EthicalProfessionalStartDate,EthicalProfessionalEndDate,ElectivesStartDate,ElectivesEndDate,ZeroToleranceStartDate,ZeroToleranceEndDate,DCCCStartDate,DCCCEndDate,FirstAidStartDate,FirstAidEndDate,APDHIPAAStartDate,APDHIPAAEndDate,CPRStartDate,CPREndDate,HIVAIDSStartDate,HIVAIDSEndDate,SocialSecurityStartDate,SocialSecurityEndDate,InServiceTrainingStartDate,InServiceTrainingEndDate,RelatedToEmploymentStartDate,RelatedToEmploymentEndDate,MedicationAdministrationStartDate,MedicationAdministrationEndDate,ReactiveStrategiesStartDate,ReactiveStrategiesEndDate")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Email,Title,Address,City,State,Zip,Phone,DateOfBirth,HireDate,LicenseNumber,CBHT,APDSupportedLiving,APDSupportedEmployement,DCFHippastartDate,DCFHippaEndDate,VehicleRegistrationStartDate,VehicleRegistrationEndDate,VehicleInsuranceCardStartDate,VehicleInsuranceCardEndDate,YearlyEvaluationStartDate,YearlyEvaluationEndDate,TargetCaseManagmentStartDate,TargetCaseManagmentEndDate,AffidavitOfGoodMoralCharacterStartDate,AffidavitOfGoodMoralCharacterEndDate,FDLEBGSStartDate,FDLEBGSEndDate,JSOLocalBGSStartDate,JSOLocalBGSEndDate,ANRPStartDate,ANRPEndDate,ClinicalCompetenceStartDate,ClinicalCompetenceEndDate,ClientPersonalSafetyStartDate,ClientPersonalSafetyEndDate,PatientConfidentialityStartDate,PatientConfidentialityEndDate,EthicalProfessionalStartDate,EthicalProfessionalEndDate,ElectivesStartDate,ElectivesEndDate,ZeroToleranceStartDate,ZeroToleranceEndDate,DCCCStartDate,DCCCEndDate,FirstAidStartDate,FirstAidEndDate,APDHIPAAStartDate,APDHIPAAEndDate,CPRStartDate,CPREndDate,HIVAIDSStartDate,HIVAIDSEndDate,SocialSecurityStartDate,SocialSecurityEndDate,InServiceTrainingStartDate,InServiceTrainingEndDate,RelatedToEmploymentStartDate,RelatedToEmploymentEndDate,MedicationAdministrationStartDate,MedicationAdministrationEndDate,ReactiveStrategiesStartDate,ReactiveStrategiesEndDate")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Certifications/5
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Certifications(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(string id)
        {
            return _context.Employee.Any(e => e.Id == id);
        }
    }
}

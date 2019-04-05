using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeTrackingSystem.Models;
using Microsoft.AspNetCore.Authorization;
using System.Net.Mail;
using EmployeeTrackingSystem.Data;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace EmployeeTrackingSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "The Employee Portal";
            return View();
        }

        public async Task<IActionResult> Reports()
        {
            ViewData["Message"] = "The Reports page";

            return View(await _context.Employee.ToListAsync());
        }

        public IActionResult Download()
        {
            byte[] fileContents;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                IList<Employee> employeeList = _context.Employee.ToList();
                int totalRows = employeeList.Count();

                worksheet.Cells[1, 1].Value = "Full Name";
                worksheet.Cells[1, 2].Value = "Address";
                worksheet.Cells[1, 3].Value = "City";
                worksheet.Cells[1, 4].Value = "State";
                worksheet.Cells[1, 5].Value = "Zip";
                worksheet.Cells[1, 6].Value = "Phone";
                worksheet.Cells[1, 7].Value = "Email";
                worksheet.Cells[1, 8].Value = "Date Of Birth";
                worksheet.Cells[1, 9].Value = "Title";
                worksheet.Cells[1, 10].Value = "Hire Date";
                worksheet.Cells[1, 11].Value = "License Number";
                worksheet.Cells[1, 12].Value = "Certification Type";
                worksheet.Cells[1, 13].Value = "Certification Start Date";
                worksheet.Cells[1, 14].Value = "Certification End Date";
                worksheet.Cells[1, 15].Value = "Hours";

                int i = 0;
                int row = 2;
                for (int r = 2; r <= totalRows + 1; r++)
                {
                    worksheet.Cells[row, 1].Value = employeeList[i].Name;
                    worksheet.Cells[row, 2].Value = employeeList[i].Address;
                    worksheet.Cells[row, 3].Value = employeeList[i].City;
                    worksheet.Cells[row, 4].Value = employeeList[i].State;
                    worksheet.Cells[row, 5].Value = employeeList[i].Zip;
                    worksheet.Cells[row, 6].Value = employeeList[i].Phone;
                    worksheet.Cells[row, 7].Value = employeeList[i].Email;
                    worksheet.Cells[row, 8].Value = employeeList[i].DateOfBirth;
                    worksheet.Cells[row, 8].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 9].Value = employeeList[i].Title;
                    worksheet.Cells[row, 10].Value = employeeList[i].HireDate;
                    worksheet.Cells[row, 10].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 11].Value = employeeList[i].LicenseNumber;

                    worksheet.Cells[row, 12].Value = "DCF Hippa";
                    worksheet.Cells[row, 13].Value = employeeList[i].DCFHippastartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].DCFHippaEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;
                    worksheet.Cells[row, 1].Value = employeeList[i].Name;
                    worksheet.Cells[row, 12].Value = "Vehicle Registration";
                    worksheet.Cells[row, 13].Value = employeeList[i].VehicleRegistrationStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].VehicleRegistrationEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;
                    worksheet.Cells[row, 1].Value = employeeList[i].Name;
                    worksheet.Cells[row, 12].Value = "Vehicle Insurance";
                    worksheet.Cells[row, 13].Value = employeeList[i].VehicleInsuranceCardStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].VehicleInsuranceCardEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;
                    worksheet.Cells[row, 1].Value = employeeList[i].Name;
                    worksheet.Cells[row, 12].Value = "Yearly Evaluation";
                    worksheet.Cells[row, 13].Value = employeeList[i].YearlyEvaluationStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].YearlyEvaluationEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;
                    worksheet.Cells[row, 1].Value = employeeList[i].Name;
                    worksheet.Cells[row, 12].Value = "TargetCaseManagment";
                    worksheet.Cells[row, 13].Value = employeeList[i].TargetCaseManagmentStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].TargetCaseManagmentEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;
                    worksheet.Cells[row, 1].Value = employeeList[i].Name;
                    worksheet.Cells[row, 12].Value = "Affidavit Of Good Moral Character";
                    worksheet.Cells[row, 13].Value = employeeList[i].AffidavitOfGoodMoralCharacterStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].AffidavitOfGoodMoralCharacterEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;
                    worksheet.Cells[row, 1].Value = employeeList[i].Name;
                    worksheet.Cells[row, 12].Value = "FDLE-BGS";
                    worksheet.Cells[row, 13].Value = employeeList[i].FDLEBGSStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].FDLEBGSEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;
                    worksheet.Cells[row, 1].Value = employeeList[i].Name;
                    worksheet.Cells[row, 12].Value = "JSO Local BGS";
                    worksheet.Cells[row, 13].Value = employeeList[i].JSOLocalBGSStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].JSOLocalBGSEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;

                    if (employeeList[i].CBHT)
                    {
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "ANRP";
                        worksheet.Cells[row, 13].Value = employeeList[i].ANRPStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].ANRPEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "Clinical Competence";
                        worksheet.Cells[row, 13].Value = employeeList[i].ClinicalCompetenceStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].ClinicalCompetenceEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "Maintaining Client and Personal Safety";
                        worksheet.Cells[row, 13].Value = employeeList[i].ClientPersonalSafetyStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].ClientPersonalSafetyEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "Documentation and Patient Confidentiality";
                        worksheet.Cells[row, 13].Value = employeeList[i].PatientConfidentialityStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].PatientConfidentialityEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "Ethical and Professional Responsibilities";
                        worksheet.Cells[row, 13].Value = employeeList[i].EthicalProfessionalStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].EthicalProfessionalEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "Electives";
                        worksheet.Cells[row, 13].Value = employeeList[i].ElectivesStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].ElectivesEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                    }

                    if (employeeList[i].APDSupportedLiving || employeeList[i].APDSupportedEmployement)
                    {
                        //both
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "Zero Tolerance";
                        worksheet.Cells[row, 13].Value = employeeList[i].ZeroToleranceStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].ZeroToleranceEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "Direct Care Core Competencies";
                        worksheet.Cells[row, 13].Value = employeeList[i].DCCCStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].DCCCEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "First Aid";
                        worksheet.Cells[row, 13].Value = employeeList[i].FirstAidStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].FirstAidEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "APD HIPAA";
                        worksheet.Cells[row, 13].Value = employeeList[i].APDHIPAAStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].APDHIPAAEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "CPR";
                        worksheet.Cells[row, 13].Value = employeeList[i].CPRStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].CPREndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "HIV-AIDS/Bloodborne Pathogens";
                        worksheet.Cells[row, 13].Value = employeeList[i].HIVAIDSStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].HIVAIDSEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                    }

                    if (employeeList[i].APDSupportedLiving)
                    {
                        //living only
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "Social Security Work Incentives";
                        worksheet.Cells[row, 13].Value = employeeList[i].SocialSecurityStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].SocialSecurityEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";           
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "In-service Training";
                        worksheet.Cells[row, 13].Value = employeeList[i].InServiceTrainingStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].InServiceTrainingEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 15].Value = employeeList[i].InServiceTrainingHours;
                        row++;
                    }

                    if (employeeList[i].APDSupportedEmployement)
                    {
                        //employment only
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "In-service Training Related to Employment";
                        worksheet.Cells[row, 13].Value = employeeList[i].RelatedToEmploymentStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].RelatedToEmploymentEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 15].Value = employeeList[i].RelatedToEmploymentHours;
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "Medication Administration";
                        worksheet.Cells[row, 13].Value = employeeList[i].MedicationAdministrationStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].MedicationAdministrationEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                        worksheet.Cells[row, 1].Value = employeeList[i].Name;
                        worksheet.Cells[row, 12].Value = "Reactive Strategies";
                        worksheet.Cells[row, 13].Value = employeeList[i].ReactiveStrategiesStartDate;
                        worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                        worksheet.Cells[row, 14].Value = employeeList[i].ReactiveStrategiesEndDate;
                        worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                        row++;
                    }
                    i++;
                }

                using (ExcelRange objRange = worksheet.Cells["A1:XFD1"])
                {
                    objRange.Style.Font.Bold = true;
                    objRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    objRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            }
                worksheet.Cells["A1:XFD500"].AutoFitColumns();
                fileContents = package.GetAsByteArray();
            }

            if (fileContents == null || fileContents.Length == 0)
            {
                return NotFound();
            }

            return File(
                fileContents: fileContents,
                contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileDownloadName: DateTime.Now.ToString("MM_dd_yy") + "_Employee_Tracking_Report.xlsx"
            );
        }

        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Email()
        {
            ViewData["Message"] = "The Email page";

            return View(await _context.Employee.ToListAsync());
        }
        
         public IActionResult Open()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Email(EmployeeTrackingSystem.Models.EmailModel model)
        //{
        //    MailMessage message = new MailMessage("huntsville37@gmail.com", model.To);
        //    message.Subject = model.Subject;
        //    message.Body = model.Body;
        //    message.IsBodyHtml = false;

        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    //smtp.Host = "smtp.yahoo.com";
        //    //smtp.Host = "smtp.outlook.com";
        //    smtp.Port = 587;
        //    smtp.EnableSsl = true;



        //    smtp.UseDefaultCredentials = true;
        //    smtp.Credentials = new System.Net.NetworkCredential("huntsville37@gmail.com", "password");
        //    smtp.Send(message);
        //    ViewBag.Message = "message sent";
        //    return View();

        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

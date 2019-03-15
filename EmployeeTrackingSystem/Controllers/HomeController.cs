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
                worksheet.Cells[1, 2].Value = "Email";
                worksheet.Cells[1, 3].Value = "Title";
                worksheet.Cells[1, 4].Value = "Address";
                worksheet.Cells[1, 5].Value = "City";
                worksheet.Cells[1, 6].Value = "State";
                worksheet.Cells[1, 7].Value = "Zip";
                worksheet.Cells[1, 8].Value = "Phone";
                worksheet.Cells[1, 9].Value = "Date Of Birth";
                worksheet.Cells[1, 10].Value = "Hire Date";
                worksheet.Cells[1, 11].Value = "License Number";
                worksheet.Cells[1, 12].Value = "Certification Type";
                worksheet.Cells[1, 13].Value = "Certification Start Date";
                worksheet.Cells[1, 14].Value = "Certification End Date";

                int i = 0;
                int row = 2;
                for (int r = 2; r <= totalRows + 1; r++)
                {
                    worksheet.Cells[row, 1].Value = employeeList[i].Name;
                    worksheet.Cells[row, 2].Value = employeeList[i].Email;
                    worksheet.Cells[row, 3].Value = employeeList[i].Title;
                    //employees titles and shift all collumns up by one
                    worksheet.Cells[row, 4].Value = employeeList[i].Address;
                    worksheet.Cells[row, 5].Value = employeeList[i].City;
                    worksheet.Cells[row, 6].Value = employeeList[i].State;
                    worksheet.Cells[row, 7].Value = employeeList[i].Zip;
                    worksheet.Cells[row, 8].Value = employeeList[i].Phone;
                    worksheet.Cells[row, 9].Value = employeeList[i].DateOfBirth;
                    worksheet.Cells[row, 9].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 10].Value = employeeList[i].HireDate;
                    worksheet.Cells[row, 10].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 11].Value = employeeList[i].LicenseNumber;

                    worksheet.Cells[row, 12].Value = "DCF Hippa";
                    worksheet.Cells[row, 13].Value = employeeList[i].DCFHippastartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].DCFHippaEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;

                    worksheet.Cells[row, 12].Value = "Vehicle Registration";
                    worksheet.Cells[row, 13].Value = employeeList[i].VehicleRegistrationStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].VehicleRegistrationEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;

                    worksheet.Cells[row, 12].Value = "Vehicle Insurance";
                    worksheet.Cells[row, 13].Value = employeeList[i].VehicleInsuranceCardStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].VehicleInsuranceCardEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;

                    worksheet.Cells[row, 12].Value = "Yearly Evaluation";
                    worksheet.Cells[row, 13].Value = employeeList[i].YearlyEvaluationStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].YearlyEvaluationEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;

                    worksheet.Cells[row, 12].Value = "TargetCaseManagment";
                    worksheet.Cells[row, 13].Value = employeeList[i].TargetCaseManagmentStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].TargetCaseManagmentEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;

                    worksheet.Cells[row, 12].Value = "Affidavit Of Good Moral Character";
                    worksheet.Cells[row, 13].Value = employeeList[i].AffidavitOfGoodMoralCharacterStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].AffidavitOfGoodMoralCharacterEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;

                    worksheet.Cells[row, 12].Value = "FDLE-BGS";
                    worksheet.Cells[row, 13].Value = employeeList[i].FDLEBGSStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].FDLEBGSEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;

                    worksheet.Cells[row, 12].Value = "JSO Local BGS";
                    worksheet.Cells[row, 13].Value = employeeList[i].JSOLocalBGSStartDate;
                    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    worksheet.Cells[row, 14].Value = employeeList[i].JSOLocalBGSEndDate;
                    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    row++;
                    //if (employeeList[i].RequiredCerts.Contains("1"))
                    //{
                    //    worksheet.Cells[row, 12].Value = "cert 1";
                    //    worksheet.Cells[row, 13].Value = employeeList[i].Cert1StartDate;
                    //    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    //    worksheet.Cells[row, 14].Value = employeeList[i].Cert1EndDate;
                    //    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    //    row++;
                    //}
                    //if (employeeList[i].RequiredCerts.Contains("2"))
                    //{
                    //    worksheet.Cells[row, 12].Value = "cert 2";
                    //    worksheet.Cells[row, 13].Value = employeeList[i].Cert2StartDate;
                    //    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    //    worksheet.Cells[row, 14].Value = employeeList[i].Cert2EndDate;
                    //    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    //    row++;
                    //}
                    //if (employeeList[i].RequiredCerts.Contains("3"))
                    //{
                    //    worksheet.Cells[row, 12].Value = "cert 3";
                    //    worksheet.Cells[row, 13].Value = employeeList[i].Cert3StartDate;
                    //    worksheet.Cells[row, 13].Style.Numberformat.Format = "mm/dd/yyyy";
                    //    worksheet.Cells[row, 14].Value = employeeList[i].Cert3EndDate;
                    //    worksheet.Cells[row, 14].Style.Numberformat.Format = "mm/dd/yyyy";
                    //    row++;
                    //}
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
        public IActionResult Email()
        {
            ViewData["Message"] = "The Email page";

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

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
                worksheet.Cells[1, 3].Value = "Address";
                worksheet.Cells[1, 4].Value = "City";
                worksheet.Cells[1, 5].Value = "State";
                worksheet.Cells[1, 6].Value = "Zip";
                worksheet.Cells[1, 7].Value = "Phone";
                worksheet.Cells[1, 8].Value = "Date Of Birth";
                worksheet.Cells[1, 9].Value = "Hire Date";
                worksheet.Cells[1, 10].Value = "License Number";
                worksheet.Cells[1, 11].Value = "Certification Type";
                worksheet.Cells[1, 12].Value = "Certification Start Date";
                worksheet.Cells[1, 13].Value = "Certification End Date";

                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = employeeList[i].Name;
                    worksheet.Cells[row, 2].Value = employeeList[i].Email;
                    worksheet.Cells[row, 3].Value = employeeList[i].Address;
                    worksheet.Cells[row, 4].Value = employeeList[i].City;
                    worksheet.Cells[row, 5].Value = employeeList[i].State;
                    worksheet.Cells[row, 6].Value = employeeList[i].Zip;
                    worksheet.Cells[row, 7].Value = employeeList[i].Phone;
                    worksheet.Cells[row, 8].Value = employeeList[i].DateOfBirth;
                    worksheet.Cells[row, 9].Value = employeeList[i].HireDate;
                    worksheet.Cells[row, 10].Value = employeeList[i].LicenseNumber;
                    worksheet.Cells[row, 11].Value = employeeList[i].CertificationType;
                    worksheet.Cells[row, 12].Value = employeeList[i].CertificationStartDate;
                    worksheet.Cells[row, 13].Value = employeeList[i].CertificationEndDate;
                    i++;
                }
                using (ExcelRange objRange = worksheet.Cells["A1:XFD1"])
                {
                    objRange.Style.Font.Bold = true;
                    objRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    objRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            }
                worksheet.Cells["A1:XFD50"].AutoFitColumns();
                fileContents = package.GetAsByteArray();
            }

            if (fileContents == null || fileContents.Length == 0)
            {
                return NotFound();
            }

            return File(
                fileContents: fileContents,
                contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileDownloadName: DateTime.Now.ToString("MM_dd_yy") + "_Report.xlsx"
            );
        }

        //public IActionResult Download()
        //{
        //    byte[] fileContents;

        //    using (var package = new ExcelPackage())
        //    {
        //        var worksheet = package.Workbook.Worksheets.Add("Sheet1");

        //        // Put whatever you want here in the sheet
        //        // For example, for cell on row1 col1

        //        worksheet.Cells[1, 1].Value = "Long text";
        //        worksheet.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;
        //        fileContents = package.GetAsByteArray();
        //    }

        //    if (fileContents == null || fileContents.Length == 0)
        //    {
        //        return NotFound();
        //    }

        //    return File(
        //        fileContents: fileContents,
        //        contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
        //        fileDownloadName: "Report.xlsx"
        //    );
        //}

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class Employee
    {
        [Key]
        public string Id { get; set; }
        [DisplayName("Full Name")]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string RequiredCerts { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        //[RegularExpression(@"^\+1 \(\d{3}\) \d{3}-\d{4}$", ErrorMessage = "Invalid Phone Number.")]
        public string Phone { get; set; }
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Hire Date")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        [DisplayName("License Number")]
        public int LicenseNumber { get; set; }
        [DisplayName("Certification Start Date")]
        [DataType(DataType.Date)]
        public DateTime Cert1StartDate { get; set; }//rename all certs and titles
        [DisplayName("Certification End Date")]
        [DataType(DataType.Date)]
        public DateTime Cert1EndDate { get; set; }
        [DisplayName("Certification Start Date")]
        [DataType(DataType.Date)]
        public DateTime Cert2StartDate { get; set; }
        [DisplayName("Certification End Date")]
        [DataType(DataType.Date)]
        public DateTime Cert2EndDate { get; set; }
        [DisplayName("Certification Start Date")]
        [DataType(DataType.Date)]
        public DateTime Cert3StartDate { get; set; }
        [DisplayName("Certification End Date")]
        [DataType(DataType.Date)]
        public DateTime Cert3EndDate { get; set; }
        //public bool Title1 { get; set; }
        //public bool Title2 { get; set; }
        //public bool Title3 { get; set; }
        //public bool Title4 { get; set; }
        //public bool Title5 { get; set; }
        //public bool Title6 { get; set; }
        //public bool Title7 { get; set; }
        //public bool Title8 { get; set; }
        //public bool Title9 { get; set; }
        //public bool Title10 { get; set; }
    }
}

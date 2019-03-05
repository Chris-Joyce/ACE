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
        [DisplayName("Certification Type")]
        public string CertificationType { get; set; }
        [DisplayName("Certification Start Date")]
        [DataType(DataType.Date)]
        public DateTime CertificationStartDate { get; set; }
        [DisplayName("Certification End Date")]
        [DataType(DataType.Date)]
        public DateTime CertificationEndDate { get; set; }
    }
}

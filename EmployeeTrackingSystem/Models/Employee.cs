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
        public string Title { get; set; }
        //public string RequiredCerts { get; set; }
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
        //[DisplayName("Certification Start Date")]
        //[DataType(DataType.Date)]
        //public DateTime Cert1StartDate { get; set; }//rename all certs and titles
        //[DisplayName("Certification End Date")]
        //[DataType(DataType.Date)]
        //public DateTime Cert1EndDate { get; set; }
        //[DisplayName("Certification Start Date")]
        //[DataType(DataType.Date)]
        //public DateTime Cert2StartDate { get; set; }
        //[DisplayName("Certification End Date")]
        //[DataType(DataType.Date)]
        //public DateTime Cert2EndDate { get; set; }
        //[DisplayName("Certification Start Date")]
        //[DataType(DataType.Date)]
        //public DateTime Cert3StartDate { get; set; }
        //[DisplayName("Certification End Date")]
        //[DataType(DataType.Date)]
        //public DateTime Cert3EndDate { get; set; }
    

        //All Employees have these
        [DisplayName("DCF Hippa Start Date")]
        [DataType(DataType.Date)]
        public DateTime DCFHippastartDate { get; set; }
        [DisplayName("DCF Hippa End Date")]
        [DataType(DataType.Date)]
        public DateTime DCFHippaEndDate { get; set; }

        [DisplayName("Vehicle Registration Start Date")]
        [DataType(DataType.Date)]
        public DateTime VehicleRegistrationStartDate { get; set; }
        [DisplayName("Vehicle Registration End Date")]
        [DataType(DataType.Date)]
        public DateTime VehicleRegistrationEndDate { get; set; }

        [DisplayName("Vehicle Insurance Card Start Date")]
        [DataType(DataType.Date)]
        public DateTime VehicleInsuranceCardStartDate { get; set; }
        [DisplayName("Vehicle Insurance Card End Date")]
        [DataType(DataType.Date)]
        public DateTime VehicleInsuranceCardEndDate { get; set; }

        [DisplayName("Yearly Evaluation Start Date")]
        [DataType(DataType.Date)]
        public DateTime YearlyEvaluationStartDate { get; set; }
        [DisplayName("Yearly Evaluation End Date")]
        [DataType(DataType.Date)]
        public DateTime YearlyEvaluationEndDate { get; set; }

        [DisplayName("Target Case Managment Certification Start Date")]
        [DataType(DataType.Date)]
        public DateTime TargetCaseManagmentStartDate { get; set; }
        [DisplayName("Target Case Managment Certification End Date")]
        [DataType(DataType.Date)]
        public DateTime TargetCaseManagmentEndDate { get; set; }

        [DisplayName("Affidavit of Good Moral Character Start Date")]
        [DataType(DataType.Date)]
        public DateTime AffidavitOfGoodMoralCharacterStartDate { get; set; }
        [DisplayName("Affidavit of Good Moral Character End Date")]
        [DataType(DataType.Date)]
        public DateTime AffidavitOfGoodMoralCharacterEndDate { get; set; }

        [DisplayName("FDLE-BGS Start Date")]
        [DataType(DataType.Date)]
        public DateTime FDLEBGSStartDate { get; set; }
        [DisplayName("FDLE-BGS End Date")]
        [DataType(DataType.Date)]
        public DateTime FDLEBGSEndDate { get; set; }

        [DisplayName("JSO Local BGS Start Date")]
        [DataType(DataType.Date)]
        public DateTime JSOLocalBGSStartDate { get; set; }
        [DisplayName("JSO Local BGS End Date")]
        [DataType(DataType.Date)]
        public DateTime JSOLocalBGSEndDate { get; set; }


        ////cbht
        //[DisplayName("Certification Start Date")]
        //[DataType(DataType.Date)]
        //public DateTime Cert9StartDate { get; set; }
        //[DisplayName("Certification End Date")]
        //[DataType(DataType.Date)]
        //public DateTime Cert9EndDate { get; set; }
        //[DisplayName("Certification Start Date")]
        //[DataType(DataType.Date)]
        //public DateTime Cert10StartDate { get; set; }
        //[DisplayName("Certification End Date")]
        //[DataType(DataType.Date)]
        //public DateTime Cert10endDate { get; set; }
        //public bool CBHT { get; set; }
        //[DisplayName("APD Supported Living")]
        //public bool APDSupportedLiving { get; set; }
        //[DisplayName("APD Supported Employement")]
        //public bool APDSupportedEmployement { get; set; }
    }
}

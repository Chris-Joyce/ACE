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
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Hire Date")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        [DisplayName("License Number")]
        public string LicenseNumber { get; set; }

        //check boxes
        public bool CBHT { get; set; }
        [DisplayName("APD Supported Living")]
        public bool APDSupportedLiving { get; set; }
        [DisplayName("APD Supported Employement")]
        public bool APDSupportedEmployement { get; set; }
        public bool ARNP { get; set; }

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

        //arnp
        [DisplayName("DEA Start Date")]
        [DataType(DataType.Date)]
        public DateTime DEAStartDate { get; set; }
        [DisplayName("DEA End Date")]
        [DataType(DataType.Date)]
        public DateTime DEAEndDate { get; set; }

        [DisplayName("Licence Start Date")]
        [DataType(DataType.Date)]
        public DateTime ARNPLicenceStartDate { get; set; }
        [DisplayName("Licence End Date")]
        [DataType(DataType.Date)]
        public DateTime ARNPLicenceEndDate { get; set; }

        [DisplayName("Insurance Start Date")]
        [DataType(DataType.Date)]
        public DateTime InsuranceStartDate { get; set; }
        [DisplayName("Insurance End Date")]
        [DataType(DataType.Date)]
        public DateTime InsuranceEndDate { get; set; }

        //cbht
        [DisplayName("Clinical Competence Start Date")]
        [DataType(DataType.Date)]
        public DateTime ClinicalCompetenceStartDate { get; set; }
        [DisplayName("Clinical Competence End Date")]
        [DataType(DataType.Date)]
        public DateTime ClinicalCompetenceEndDate { get; set; }

        [DisplayName("Maintaining Client and Personal Safety Start Date")]
        [DataType(DataType.Date)]
        public DateTime ClientPersonalSafetyStartDate { get; set; }
        [DisplayName("Maintaining Client and Personal Safety End Date")]
        [DataType(DataType.Date)]
        public DateTime ClientPersonalSafetyEndDate { get; set; }

        [DisplayName("Documentation and Patient Confidentiality Start Date")]
        [DataType(DataType.Date)]
        public DateTime PatientConfidentialityStartDate { get; set; }
        [DisplayName("Documentation and Patient Confidentiality End Date")]
        [DataType(DataType.Date)]
        public DateTime PatientConfidentialityEndDate { get; set; }

        [DisplayName("Ethical and Professional Responsibilities Start Date")]
        [DataType(DataType.Date)]
        public DateTime EthicalProfessionalStartDate { get; set; }
        [DisplayName("Ethical and Professional Responsibilities End Date")]
        [DataType(DataType.Date)]
        public DateTime EthicalProfessionalEndDate { get; set; }

        [DisplayName("Electives Start Date")]
        [DataType(DataType.Date)]
        public DateTime ElectivesStartDate { get; set; }
        [DisplayName("Electives End Date")]
        [DataType(DataType.Date)]
        public DateTime ElectivesEndDate { get; set; }

        //supported living & supported employment
        //waiver providers

        [DisplayName("Zero Tolerance Start Date")]
        [DataType(DataType.Date)]
        public DateTime ZeroToleranceStartDate { get; set; }
        [DisplayName("Zero Tolerance End Date")]
        [DataType(DataType.Date)]
        public DateTime ZeroToleranceEndDate { get; set; }

        [DisplayName("Direct Care Core Competencies Start Date")]
        [DataType(DataType.Date)]
        public DateTime DCCCStartDate { get; set; }
        [DisplayName("Direct Care Core Competencies End Date")]
        [DataType(DataType.Date)]
        public DateTime DCCCEndDate { get; set; }

        [DisplayName("First Aid Start Date")]
        [DataType(DataType.Date)]
        public DateTime FirstAidStartDate { get; set; }
        [DisplayName("First Aid End Date")]
        [DataType(DataType.Date)]
        public DateTime FirstAidEndDate { get; set; }

        [DisplayName("APD HIPAA Start Date")]
        [DataType(DataType.Date)]
        public DateTime APDHIPAAStartDate { get; set; }
        [DisplayName("APD HIPAA End Date")]
        [DataType(DataType.Date)]
        public DateTime APDHIPAAEndDate { get; set; }

        [DisplayName("CPR Start Date")]
        [DataType(DataType.Date)]
        public DateTime CPRStartDate { get; set; }
        [DisplayName("CPR End Date")]
        [DataType(DataType.Date)]
        public DateTime CPREndDate { get; set; }

        [DisplayName("HIV-AIDS/Bloodborne Pathogens Start Date")]
        [DataType(DataType.Date)]
        public DateTime HIVAIDSStartDate { get; set; }
        [DisplayName("HIV-AIDS/Bloodborne Pathogens End Date")]
        [DataType(DataType.Date)]
        public DateTime HIVAIDSEndDate { get; set; }

        //supported living only

        [DisplayName("Social Security Work Incentives Start Date")]
        [DataType(DataType.Date)]
        public DateTime SocialSecurityStartDate { get; set; }
        [DisplayName("Social Security Work Incentives End Date")]
        [DataType(DataType.Date)]
        public DateTime SocialSecurityEndDate { get; set; }

        [DisplayName("In-service Training Start Date")]
        [DataType(DataType.Date)]
        public DateTime InServiceTrainingStartDate { get; set; }
        [DisplayName("In-service Training End Date")]
        [DataType(DataType.Date)]
        public DateTime InServiceTrainingEndDate { get; set; }
        [DisplayName("In-service Training Hours")]
        public int InServiceTrainingHours { get; set; }

        //supported employment only
        [DisplayName("In-service Training Related to Employment Start Date")]
        [DataType(DataType.Date)]
        public DateTime RelatedToEmploymentStartDate { get; set; }
        [DisplayName("In-service Training Related to Employment End Date")]
        [DataType(DataType.Date)]
        public DateTime RelatedToEmploymentEndDate { get; set; }
        [DisplayName("In-service Training Related to Employment Hours")]
        public int RelatedToEmploymentHours { get; set; }

        [DisplayName("Medication Administration Training Start Date")]
        [DataType(DataType.Date)]
        public DateTime MedicationAdministrationStartDate { get; set; }
        [DisplayName("Medication Administration Training End Date")]
        [DataType(DataType.Date)]
        public DateTime MedicationAdministrationEndDate { get; set; }

        [DisplayName("Reactive Strategies Start Date")]
        [DataType(DataType.Date)]
        public DateTime ReactiveStrategiesStartDate { get; set; }
        [DisplayName("Reactive Strategies End Date")]
        [DataType(DataType.Date)]
        public DateTime ReactiveStrategiesEndDate { get; set; }

        public string Notes { get; set; }
    }
}

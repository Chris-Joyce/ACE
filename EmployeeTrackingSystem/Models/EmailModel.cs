using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class EmailModel
    {
        public string From { get; set; }

        public string To { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public string Sent { get; set; }
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int LicenseNumber { get; set;}

        [DisplayName("DCF Hippa End Date")]
        [DataType(DataType.Date)]
        public DateTime DCFHippaEndDate { get; set; }

        public DateTime VehicleRegistrationEndDate { get; set; }

       
        [DisplayName("Vehicle Insurance Card End Date")]
        [DataType(DataType.Date)]
        public DateTime VehicleInsuranceCardEndDate { get; set; }

        [DisplayName("Yearly Evaluation End Date")]
        [DataType(DataType.Date)]
        public DateTime YearlyEvaluationEndDate { get; set; }

       
        [DisplayName("Target Case Managment Certification End Date")]
        [DataType(DataType.Date)]
        public DateTime TargetCaseManagmentEndDate { get; set; }

       
        [DisplayName("Affidavit of Good Moral Character End Date")]
        [DataType(DataType.Date)]
        public DateTime AffidavitOfGoodMoralCharacterEndDate { get; set; }

      
        [DisplayName("FDLE-BGS End Date")]
        [DataType(DataType.Date)]
        public DateTime FDLEBGSEndDate { get; set; }

       
        [DisplayName("JSO Local BGS End Date")]
        [DataType(DataType.Date)]
        public DateTime JSOLocalBGSEndDate { get; set; }


        //cbht
     
        [DisplayName("ANRP End Date")]
        [DataType(DataType.Date)]
        public DateTime ANRPEndDate { get; set; }

       
        [DisplayName("Clinical Competence End Date")]
        [DataType(DataType.Date)]
        public DateTime ClinicalCompetenceEndDate { get; set; }

        [DisplayName("Maintaining Client and Personal Safety End Date")]
        [DataType(DataType.Date)]
        public DateTime ClientPersonalSafetyEndDate { get; set; }

      
        [DisplayName("Documentation and Patient Confidentiality End Date")]
        [DataType(DataType.Date)]
        public DateTime PatientConfidentialityEndDate { get; set; }

       
        [DisplayName("Ethical and Professional Responsibilities End Date")]
        [DataType(DataType.Date)]
        public DateTime EthicalProfessionalEndDate { get; set; }

      
        [DisplayName("Electives End Date")]
        [DataType(DataType.Date)]
        public DateTime ElectivesEndDate { get; set; }

        //supported living & supported employment
        //waiver providers

       
        [DisplayName("Zero Tolerance End Date")]
        [DataType(DataType.Date)]
        public DateTime ZeroToleranceEndDate { get; set; }

        
        [DisplayName("Direct Care Core Competencies End Date")]
        [DataType(DataType.Date)]
        public DateTime DCCCEndDate { get; set; }

        [DisplayName("First Aid End Date")]
        [DataType(DataType.Date)]
        public DateTime FirstAidEndDate { get; set; }

        [DisplayName("APD HIPAA End Date")]
        [DataType(DataType.Date)]
        public DateTime APDHIPAAEndDate { get; set; }

        [DisplayName("CPR End Date")]
        [DataType(DataType.Date)]
        public DateTime CPREndDate { get; set; }

        [DisplayName("HIV-AIDS/Bloodborne Pathogens End Date")]
        [DataType(DataType.Date)]
        public DateTime HIVAIDSEndDate { get; set; }

        //supported living only

        [DisplayName("Social Security Work Incentives End Date")]
        [DataType(DataType.Date)]
        public DateTime SocialSecurityEndDate { get; set; }

        [DisplayName("In-service Training End Date")]
        [DataType(DataType.Date)]
        public DateTime InServiceTrainingEndDate { get; set; }

        //supported employment only
      
        [DisplayName("In-service Training Related to Employment End Date")]
        [DataType(DataType.Date)]
        public DateTime RelatedToEmploymentEndDate { get; set; }

        [DisplayName("Medication Administration Training End Date")]
        [DataType(DataType.Date)]
        public DateTime MedicationAdministrationEndDate { get; set; }

        [DisplayName("Reactive Strategies End Date")]
        [DataType(DataType.Date)]
        public DateTime ReactiveStrategiesEndDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class Certification
    {
        [Key]
        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }
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

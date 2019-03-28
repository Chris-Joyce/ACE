using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

       
}

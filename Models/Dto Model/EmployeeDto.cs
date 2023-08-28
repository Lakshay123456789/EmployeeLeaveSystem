using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto_Model
{
     public class EmployeeDto
    {
        [Required]
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string ? PhoneNumber { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public int PinCode { get; set; }

        public int? DepartmentId { get; set; }
    }
}

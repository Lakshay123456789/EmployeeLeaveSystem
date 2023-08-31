using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto_Model
{
    public class DepartmentDto
    {
        [Required]
        public string? DepartmentName { get; set; }
    }
}

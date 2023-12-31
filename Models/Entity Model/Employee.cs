﻿using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity_Model
{
     public  class Employee
    {

        public Guid Id { get; set; }

        [Required]
        public string ? FirstName { get; set; }

        public string  ? LastName { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public string ? Email { get; set; }

        [Required]
        public int  PhoneNumber { get; set; }

        [Required]  
        public string  ? Address { get; set; }

        [Required]
        public int PinCode { get; set; }

        [ForeignKey("Department")]
        public int ? DepartmentId { get; set; }
         

    }
}

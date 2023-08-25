using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity_Model
{
    public class User:IdentityUser
    {
        [Required]
        public string ?  FirstName { get; set; }

        public string ? LastName { get; set; }
    }
}

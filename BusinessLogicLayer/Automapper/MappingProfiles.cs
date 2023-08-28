using AutoMapper;
using Models.Dto_Model;
using Models.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Automapper
{
     public  class MappingProfiles:Profile
    {
        public MappingProfiles() {

            CreateMap<EmployeeDto, Employee>();
        }

    }
}

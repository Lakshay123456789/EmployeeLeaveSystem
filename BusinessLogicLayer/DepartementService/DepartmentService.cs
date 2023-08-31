using AutoMapper;
using BusinessLogicLayer.DepartementService.Interface;
using DataAccessLayer.Repository.Interface;
using Models.Dto_Model;
using Models.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DepartementService
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Department> _departmentGenericRepository;

        public DepartmentService(IGenericRepository<Department> departmentGenericRepository, IMapper mapper)
        {
            _mapper = mapper;
            _departmentGenericRepository = departmentGenericRepository;
          
        }

        public async Task<IEnumerable<Department>> GetAllDepartment()
        {
            return await _departmentGenericRepository.GetAllAsync();
        }
        public async Task addDepartment(DepartmentDto model)
        {
            //var department = new Department
            //{
            //    DepartmentName=model.DepartmentName
            //};
            var department= _mapper.Map<Department>(model);
            await _departmentGenericRepository.InsertAsync(department);
        }

        public async Task<Department> GetDepartmentById(int Id)
        {
            return await _departmentGenericRepository.GetByIdAsync(Id);
        }

    }
}

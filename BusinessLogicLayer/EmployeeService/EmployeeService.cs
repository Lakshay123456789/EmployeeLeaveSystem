using Models.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository.Interface;
using BusinessLogicLayer.EmployeeService.Interface;

namespace BusinessLogicLayer.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
       
        private readonly IGenericRepository<Employee> _employeegenericRepository;
        public EmployeeService(IGenericRepository<Employee> employeegenericRepository)
        {
           
            _employeegenericRepository = employeegenericRepository;

        }

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {

            return await _employeegenericRepository.GetAll();
        }
        public async Task<Employee> GetEmployeeId(Guid Id)
        {
            return await _employeegenericRepository.GetById(Id);
        }

        public async Task AddEmployee(Employee employee)
        {
            await _employeegenericRepository.Insert(employee);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            await _employeegenericRepository.Update(employee);
        }

        public async Task DeleteEmployee(Guid Id)
        {
            await _employeegenericRepository.Delete(Id);
        }
    }
}

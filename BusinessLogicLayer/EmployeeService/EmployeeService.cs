using Models.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository.Interface;
using BusinessLogicLayer.EmployeeService.Interface;
using Models.Dto_Model;
using AutoMapper;
using BusinessLogicLayer.AccountService.Interface;
using System.Net.WebSockets;

namespace BusinessLogicLayer.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;
        private readonly IGenericRepository<Employee> _employeegenericRepository;
        public EmployeeService(IGenericRepository<Employee> employeegenericRepository, IMapper mapper, IAccountService accountService)
        {
            _mapper = mapper;
            _accountService = accountService;
            _employeegenericRepository = employeegenericRepository;

        }

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {

            return await _employeegenericRepository.GetAllAsync();
        }
        public async Task<Employee> GetEmployeeId(Guid Id)
        {
            return await _employeegenericRepository.GetByIdAsync(Id);
        }

        public async Task<bool> AddEmployee(EmployeeDto model)
        {
            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.Email,
                Email = model.Email,
                NormalizedEmail = model.Email.ToUpper(),
                NormalizedUserName = model.Email.ToUpper(),

            };


            var userExist = await _accountService.RegistrationEmployee(user);
            if (!userExist)
            {
                return false;
            }
            var employee = _mapper.Map<Employee>(model);

            await _employeegenericRepository.InsertAsync(employee);

            return true;
        }

        public async Task UpdateEmployee(Guid Id, EmployeeDto employee)
        {
            var previosEmployee = await GetEmployeeId(Id);
            if (previosEmployee != null)
            {
                var updateEmployee = _mapper.Map<Employee>(employee);
                _employeegenericRepository.Update(updateEmployee);
            }
        }

        public async Task DeleteEmployee(Guid Id)
        {
            var employee = await GetEmployeeId(Id);
            await _employeegenericRepository.DeleteAsync(Id);
            if (employee.Email != null)
            {
                await _accountService.DeleteUser(employee.Email);
            }
        }
    }
}

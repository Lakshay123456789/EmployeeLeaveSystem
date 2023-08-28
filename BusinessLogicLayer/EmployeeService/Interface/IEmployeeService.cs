using Models.Dto_Model;
using Models.Entity_Model;

namespace BusinessLogicLayer.EmployeeService.Interface
{
    public interface IEmployeeService
    {
        Task<bool> AddEmployee(EmployeeDto model);

        Task DeleteEmployee(Guid Id);
        Task<IEnumerable<Employee>> GetAllEmployee();
        Task<Employee> GetEmployeeId(Guid Id);
        Task UpdateEmployee(Guid Id, EmployeeDto employee);



    }
}
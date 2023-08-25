using Models.Entity_Model;

namespace BusinessLogicLayer.EmployeeService.Interface
{
    public interface IEmployeeService
    {
        Task AddEmployee(Employee employee);
        Task DeleteEmployee(Guid Id);
        Task<IEnumerable<Employee>> GetAllEmployee();
        Task<Employee> GetEmployeeId(Guid Id);
        Task UpdateEmployee(Employee employee);
    }
}
using Models.Dto_Model;
using Models.Entity_Model;

namespace BusinessLogicLayer.DepartementService.Interface
{
    public interface IDepartmentService
    {
        Task addDepartment(DepartmentDto model);
        Task<IEnumerable<Department>> GetAllDepartment();
        Task<Department> GetDepartmentById(int Id);
    }
}
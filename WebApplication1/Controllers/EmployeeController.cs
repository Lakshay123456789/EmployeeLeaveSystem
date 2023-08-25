using BusinessLogicLayer.EmployeeService.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entity_Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService) {
            _employeeService = employeeService;
        }

        [HttpGet("GetAllEmployee")]
        public async Task<IActionResult> GetAllEmployee()
        {

            var employee =await _employeeService.GetAllEmployee();
 
            return Ok(employee);

        }
        
        
    }
}

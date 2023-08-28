using BusinessLogicLayer.EmployeeService.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dto_Model;
using Models.Entity_Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetAllEmployee")]
        public async Task<IActionResult> GetAllEmployee()
        {

            var employee = await _employeeService.GetAllEmployee();
            if (employee != null)
            {
                return Ok(employee);
            }
            return Ok();

        }

        [HttpPost("AddNewEmployee")]
        public async Task<IActionResult> AddNewEmployee(EmployeeDto model)
        {
            if (ModelState.IsValid)
            {
                var result = await _employeeService.AddEmployee(model);
                if (result)
                {
                    return Ok("successfully add employee and registration");
                }
                return NotFound("this email Id Already exist");
            }
            return NotFound("Something is wrong");
        }
        [HttpDelete("Delete Employee")]

        public async Task<IActionResult> DeleteEmployee(Guid Id)
        {
            if (Id != Guid.Empty)
            {
                await _employeeService.DeleteEmployee(Id);
                return Ok("Delete Employee Successfully");
            }
            return NotFound("Id not be null");

        }

        [HttpGet("GetByEmployeeId")]

        public async Task<IActionResult> GetEmployeeId(Guid Id)
        {
            if (Id != Guid.Empty)
            {
                var result = await _employeeService.GetEmployeeId(Id);

                return Ok(result);
            }
            return NotFound("Id not be null");
        }

        [HttpPut("editEmployee")]

        public async Task UpdateEmployeeRecord(Guid Id, EmployeeDto model)
        {
            if (Id != Guid.Empty)
            {
                if (ModelState.IsValid)
                {
                    await _employeeService.UpdateEmployee(Id, model);
                    Ok("successfully edit this Employee");
                }
                NotFound("something is missing");

            }
            NotFound("Id not be null ");

        }
    }
}

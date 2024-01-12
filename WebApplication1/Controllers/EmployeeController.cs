﻿using BusinessLogicLayer.DepartementService.Interface;
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
       private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService,IDepartmentService departmentService)
        {
            _departmentService = departmentService;
            _employeeService = employeeService;
        }

        [HttpGet("GetAllEmployee")]
        public async Task<IActionResult> GetAllEmployee()
        {
            try
            {
                var employee = await _employeeService.GetAllEmployee();
                if (employee != null)
                {
                    return Ok(employee);
                }
                return NotFound("not employee found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           

        }

        [HttpPost("AddNewEmployee")]
        public async Task<IActionResult> AddNewEmployee(EmployeeDto model)
        {
            try
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
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
         
        }
        [HttpDelete("Delete Employee")]
      
      
        public async Task<IActionResult> DeleteEmployee(Guid Id)
        {
            try
            {
                if (Id != Guid.Empty)
                {
                    await _employeeService.DeleteEmployee(Id);
                    return Ok("Delete Employee Successfully");
                }
                return NotFound("Id not be null");

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           

        }

        [HttpGet("GetByEmployeeId")]

        public async Task<IActionResult> GetEmployeeId(Guid Id)
        {
            try
            {
                if (Id != Guid.Empty)
                {
                    var result = await _employeeService.GetEmployeeId(Id);

                    return Ok(result);
                }
                return NotFound("Id not be null");   

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpPut("editEmployee")]

        public async Task UpdateEmployeeRecord(Guid Id, EmployeeDto model)
        {
            try
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
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
            

        }
        [HttpGet("AllDepartment")]
        public async Task<IActionResult> GetAllDepartment()
        {
            try
            {
                var departments = await _departmentService.GetAllDepartment();
                if (departments != null)
                {
                    return Ok(departments);
                }
                return NotFound("not department found");
            }
            catch (Exception ex)
            {
                 return BadRequest(ex.Message);
            }
           
        }
        [HttpPost("AddNewDepartment")]
        public async Task AddNewDepartments(DepartmentDto model)
        {
            try {

                if (ModelState.IsValid)
                {
                    await _departmentService.addDepartment(model);
                    Ok("department successfully");
                }

                NotFound("something went be wrong");

            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
            
        }
        [HttpGet("getByDepartmentId")]
        [ProducesResponseType(typeof(IEnumerable<Department>),200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetByDepartmentsId(int Id)
        {
            try
            {
                if (int.TryParse(Id.ToString(), out Id))
                {
                    var result = await _departmentService.GetDepartmentById(Id);
                    if (result != null)
                    {
                        return Ok(result);
                    }
                    return NotFound("This Id have not any  department found");
                }
                return NotFound("something are wrong");

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
          
        }


    }
}

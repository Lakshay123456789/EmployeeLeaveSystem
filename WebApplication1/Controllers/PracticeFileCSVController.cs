using BusinessLogicLayer.DepartementService.Interface;
using BusinessLogicLayer.EmployeeService.Interface;
using BusinessLogicLayer.FileService;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dto_Model;
using Models.Entity_Model;
using System.Text;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracticeFileCSVController : ControllerBase
    {
        private readonly ICSVService _csvService;
        private readonly List<Person> _persons;
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public PracticeFileCSVController(ICSVService csvService,IEmployeeService employeeService,IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _csvService = csvService;
            _departmentService = departmentService;
            _persons = new List<Person>
            {
                new Person
                {
                    Name="lakshay",
                    Age=23,
                },
                new Person
                {
                    Name="Harsh",
                    Age=24,
                }
            };
        }
        [HttpPost("read-employees-csv")]
        public async Task<IActionResult> GetEmployeeCSV([FromForm] IFormFileCollection file)
        {
            if (file == null || file.Count == 0)
            {
                return BadRequest("No file uploaded.");
            }
         List<List<Person>> list = new List<List<Person>>();

            var files = file.Count();

           for(var i= 0 ;i <files; i++){
                var employeeslist = await _csvService.ReadCSV<Person>(file[i].OpenReadStream());
               var temp= employeeslist.ToList<Person>();
                list.Add(temp);
            }
       //     var employees = await _csvService.ReadCSV<Person>(file[0].OpenReadStream());
         //  var employees1 = await _csvService.ReadCSV<Person>(file[1].OpenReadStream());


            return Ok(list);
        }

        [HttpGet]
        public async Task<ActionResult> export()
        {

            var ListPerson = _persons;
            //  var employeeList = await _employeeService.GetAllEmployee();
            var departmentList = await _departmentService.GetAllDepartment();
            var cc = new CsvConfiguration(new System.Globalization.CultureInfo("en-US"));
            using (var ms = new MemoryStream())
            {
                using (var sw = new StreamWriter(stream: ms, encoding: new UTF8Encoding(true)))
                {
                    using (var cw = new CsvWriter(sw, cc))
                    {
                        cw.WriteRecords(departmentList);
                    }// The stream gets flushed here.
                    return File(ms.ToArray(), "text/csv", $"export_{DateTime.Now.ToFileTime()}.csv");
                }
            }


        }


    }
}

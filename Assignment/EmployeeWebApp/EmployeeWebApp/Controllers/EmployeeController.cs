using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWebApp.Models;
using EmployeeWebApp.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly officeContext _officecontext;

        public EmployeeController(officeContext officecontext)
        {
            _officecontext = officecontext;
        }
        // GET api/values
        [HttpGet]
        public IActionResult getemployeelist()
        {
            var getemployee = _officecontext.Employee.ToList();
            return Ok(getemployee);
        }
        // GET: api/Employee/5
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {

            var result = _officecontext.Employee.First(obj => obj.EmpId == id);
            return Ok(result);

        }
        [HttpGet("Employee/{value}")]
        public IActionResult Get(string value)
        {

            var result = _officecontext.Employee.Where(obj => obj.EmpName.Contains(value));
            return Ok(result);

        }

        [HttpPost]
        public void Post([FromBody] Class value)
        {
            Employee obj = new Employee();
          
            obj.EmpName = value.EmpName;
            obj.EmpGender = value.EmpGender;
            obj.EmpPos = value.EmpPos;
            obj.EmpProject = value.EmpProject;
            _officecontext.Employee.Add(obj);
            _officecontext.SaveChanges();




        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

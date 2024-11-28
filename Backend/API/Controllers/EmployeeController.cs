using Bussiness.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet("api/employee/getall")]
        public IActionResult GetAll() {
            var result = _employeeService.GetAll();
            return Ok(result);
        }
        [HttpGet("api/employee/getbyid/{id}")]
        public IActionResult getById(int id)
        {
            var result = _employeeService.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }
            
        }
        [HttpPost("api/employee/add")]
        public IActionResult Add(Employee entity)
        {
            var result = _employeeService.Add(entity);
            return Ok(result);
        }
        [HttpPost("api/employee/update")]
        public IActionResult Update(Employee entity)
        {
            var result = _employeeService.Update(entity);
            return Ok(result);
        }
        [HttpPost("api/employee/delete")]
        public IActionResult Delete(Employee entity)
        {
            _employeeService.Delete(entity);
            return Ok(entity);
        }


    }
}

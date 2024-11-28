using Bussiness.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("api/customer/paging/{skip}/{take}")]
        public ActionResult Paging(int skip, int take) {
            var result = _customerService.Paging(skip, take);
            return Ok(result);
        }
        [HttpGet("api/customer/getbyid/{id}")]
        public IActionResult getById(int id) 
        {
            var result = _customerService.GetById(id);

            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }

            
        }
        [HttpPost("api/customer/add")]
        public IActionResult Add(Customer entity)
        {
            var result = _customerService.Add(entity);
            return Ok(result);
        }
        [HttpPost("api/customer/update")]
        public IActionResult Update(Customer entity)
        {
            var result = _customerService.Update(entity);
            return Ok(result);
        }
        [HttpPost("api/customer/delete")]
        public IActionResult Delete(Customer entity)
        {
            _customerService.Delete(entity);
            return Ok(entity);
        }

    }
}

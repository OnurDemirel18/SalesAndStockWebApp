using Bussiness.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public ValuesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("api/values/get")]
        public IActionResult Get()
        {
            var category = _categoryService.GetAll();

            return Ok(category);
        }
    }
}

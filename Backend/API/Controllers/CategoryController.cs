using Bussiness.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("api/category/paging/{skip}/{take}")]
        public List<Category> Paging(int skip, int take)
        {
            var result = _categoryService.Paging(skip, take);

            return result;
        }

        [HttpGet("api/category/getbyid/{id}")]
        public ActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }


        }
        [HttpPost("api/category/add")]
        public ActionResult Add(Category entity)
        {
            var result = _categoryService.Add(entity);

            return Ok(result);
        }

        [HttpPost("api/category/update")]
        public ActionResult Update(Category entity)
        {
            var result = _categoryService.Update(entity);

            return Ok(result);
        }

        [HttpPost("api/category/delete")]
        public ActionResult Delete(Category entity)
        {
            _categoryService.Delete(entity);

            return Ok(entity);
        }
    }
}

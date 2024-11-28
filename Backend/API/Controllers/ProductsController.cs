using Bussiness.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet("api/products/getcategorybyid/{categoryId}/{skip}/{take}")]
        public ActionResult GetCategoryById(int categoryId, int skip, int take)
        {
            var list = _productsService.GetCategoryById(categoryId, skip, take);
            return Ok(list);
        }
        [HttpGet("api/products/getbyid/{id}")]
        public ActionResult GetById(int id)
        {
            var result = _productsService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }

        }
        [HttpPost("api/products/add")]
        public ActionResult Add(Products entity)
        {
            var result = _productsService.Add(entity);

            return Ok(result);
        }

        [HttpPost("api/products/update")]
        public ActionResult Update(Products entity)
        {
            var result = _productsService.Update(entity);

            return Ok(result);
        }

        [HttpPost("api/products/delete")]
        public ActionResult Delete(Products entity)
        {
            _productsService.Delete(entity);

            return Ok(entity);
        }
    }
}

using Bussiness.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private ICitiesService _citiesService;

        public CitiesController(ICitiesService citiesService)
        {
            _citiesService = citiesService;
        }
        [HttpGet("api/cities/parentbyid/{parentId}/{skip}/{take}")]
        public IActionResult ParentById(int parentId, int skip, int take)
        {
            var result = _citiesService.ParentById(parentId, skip, take);

            return Ok(result);
        }

        [HttpGet("api/cities/getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _citiesService.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpPost("api/cities/multipledelete")]
        public IActionResult MultipleDelete(List<Cities> list)
        {
            _citiesService.MultipleDelete(list);

            return Ok(list);
        }
        [HttpPost("api/cities/add")]
        public ActionResult Add(Cities entity)
        {
            var result = _citiesService.Add(entity);

            return Ok(result);
        }

        [HttpPost("api/cities/update")]
        public ActionResult Update(Cities entity)
        {
            var result = _citiesService.Update(entity);

            return Ok(result);
        }

        [HttpPost("api/cities/delete")]
        public ActionResult Delete(Cities entity)
        {
            _citiesService.Delete(entity);

            return Ok(entity);
        }



    }
}

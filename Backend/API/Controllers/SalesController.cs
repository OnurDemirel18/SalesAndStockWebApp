using Bussiness.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    public class SalesController : ControllerBase
    {
        private ISalesService _salesService;

        public SalesController(ISalesService salesService)
        {
            _salesService = salesService;
        }

        [HttpGet("api/sales/paging/{skip}/{take}")]
        public IActionResult Paging(int skip, int take)
        {
            var result = _salesService.Paging(skip, take);

            return Ok(result);
        }

        [HttpGet("api/sales/getbyid/{id}")]
        public ActionResult GetById(int id)
        {
            var result = _salesService.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }


        }
        [HttpPost("api/sales/add")]
        public ActionResult Add(Sales entity)
        {
            var result = _salesService.Add(entity);

            return Ok(result);
        }

        [HttpPost("api/sales/update")]
        public ActionResult Update(Sales entity)
        {
            var result = _salesService.Update(entity);

            return Ok(result);
        }

        [HttpPost("api/sales/delete")]
        public ActionResult Delete(Sales entity)
        {
            _salesService.Delete(entity);

            return Ok(entity);
        }
    }
}

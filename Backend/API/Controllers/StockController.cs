using Bussiness.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    public class StockController : ControllerBase
    {
        private IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("api/stock/paging/{skip}/{take}")]
        public IActionResult Paging(int skip, int take)
        {
            var result = _stockService.Paging(skip, take);

            return Ok(result);
        }

        [HttpGet("api/stock/getbyid/{id}")]
        public ActionResult GetById(int id)
        {
            var result = _stockService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }


        }
        [HttpPost("api/stock/add")]
        public ActionResult Add(Stock entity)
        {
            var result = _stockService.Add(entity);

            return Ok(result);
        }

        [HttpPost("api/stock/update")]
        public ActionResult Update(Stock entity)
        {
            var result = _stockService.Update(entity);

            return Ok(result);
        }

        [HttpPost("api/stock/delete")]
        public ActionResult Delete(Stock entity)
        {
            _stockService.Delete(entity);

            return Ok(entity);
        }


    }
}

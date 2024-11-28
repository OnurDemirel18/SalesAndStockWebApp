using Bussiness.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    public class AbilityController : ControllerBase
    {
        private IAbilityService _abilityService;

        public AbilityController(IAbilityService abilityService)
        {
            _abilityService = abilityService;
        }

        [HttpGet("api/ability/getbyid/{id}")]
        public IActionResult getById(int id)
        {
            var result = _abilityService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpPost("api/ability/add")]
        public IActionResult Add(Ability entity)
        {
            var result = _abilityService.Add(entity);
            return Ok(result);
        }
        [HttpPost("api/ability/update")]
        public IActionResult Update(Ability entity)
        {
            var result = _abilityService.Update(entity);
            return Ok(result);
        }
        [HttpPost("api/ability/delete")]
        public IActionResult Delete(Ability entity)
        {
            _abilityService.Delete(entity);
            return Ok(entity);
        }


    }
}

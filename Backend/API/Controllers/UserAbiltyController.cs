using Bussiness.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    public class UserAbiltyController : ControllerBase
    {
        private IUserAbilityService _userAbilityService;

        
        public UserAbiltyController(IUserAbilityService userAbilityService)
        {
            _userAbilityService = userAbilityService;
        }
        [HttpGet("api/userability/getemployeebyabilityid/{abilityId}/{skip}/{take}")]
        public ActionResult GetEmployeeByAbilityId(int abilityId, int skip, int take) 
        { 
            var list = _userAbilityService.GetEmployeeByAbilityId(abilityId, skip, take);
            return Ok(list);
        }
        [HttpGet("api/userability/getbyid/{id}")]
        public ActionResult GetById(int id) {
            var result = _userAbilityService.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpPost("api/userability/add")]
        public IActionResult Add(UserAbility entity)
        {
            var result = _userAbilityService.Add(entity);

            return Ok(result);  
        }
        [HttpPost("api/userability/update")]
        public IActionResult Update(UserAbility entity)
        {
            var result = _userAbilityService.Update(entity);

            return Ok(result);
        }
        [HttpPost("api/userability/delete")]
        public IActionResult Delete(UserAbility entity)
        {
             _userAbilityService.Delete(entity);

            return Ok(entity);
        }


    }
}

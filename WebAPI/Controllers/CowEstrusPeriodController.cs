using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CowEstrusPeriodController : ControllerBase
    {
        ICowEstrusPeriodService _cowEstrusPeriodService;

        public CowEstrusPeriodController(ICowEstrusPeriodService cowEstrusPeriodService)
        {
            _cowEstrusPeriodService = cowEstrusPeriodService;
        }

        [HttpPost("CowEstrusPeriodAdd")]
        public IActionResult Add(int cowId, int illnessId, string estrusPeriodDate)
        {
            var result = _cowEstrusPeriodService.AutoAdd(cowId, estrusPeriodDate);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("CowEstrusPeriodGetAll")]

        public IActionResult GetAll()
        {
            var result = _cowEstrusPeriodService.GetAll();
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("CowEstrusPeriodUpdate")]

        public IActionResult Update(CowEstrusPeriod entity)
        {
            var result = _cowEstrusPeriodService.Update(entity);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("CowEstrusPeriodDelete")]

        public IActionResult Delete(CowEstrusPeriod entity)
        {
            var result = _cowEstrusPeriodService.Delete(entity);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("CowEstrusPeriodGetAllDetails")]
        public IActionResult GetAllDetails()
        {
            var result = _cowEstrusPeriodService.GetAllDetails();
            if (result.IsSuccess == true)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("CowEstrusPeriodGetDetailsByCowId")]
        public IActionResult GetDetailsByCowId(int cowId)
        {
            var result = _cowEstrusPeriodService.GetDetailsByCowId(cowId);
            if (result.IsSuccess == true)
                return Ok(result);
            return BadRequest(result);
        }
        
    }
}


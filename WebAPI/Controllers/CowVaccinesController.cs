using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CowVaccinesController : ControllerBase
    {
        ICowVaccineService _cowVaccineService;

        public CowVaccinesController(ICowVaccineService cowVaccineService)
        {
            _cowVaccineService = cowVaccineService;
        }

        [HttpPost("CowVaccinesAdd")]
        public IActionResult Add(int cowId, int vaccineId, string vaccinationDate)
        {
            var result = _cowVaccineService.AutoAdd(cowId,vaccineId,vaccinationDate);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("CowVaccinesGetAll")]

        public IActionResult GetAll()
        {
            var result = _cowVaccineService.GetAll();
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("CowVaccinesUpdate")]

        public IActionResult Update(CowVaccine entity)
        {
            var result = _cowVaccineService.Update(entity);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("CowVaccinesDelete")]
        public IActionResult Delete(CowVaccine entity)
        {
            var result = _cowVaccineService.Delete(entity);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("CowVaccinesGetAllDetails")]
        public IActionResult GetAllDetails()
        {
            var result = _cowVaccineService.GetAllDetails();
            if (result.IsSuccess == true)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("CowVaccinesGetDetailsByCowId")]
        public IActionResult GetDetailsByCowId(int cowId)
        {
            var result = _cowVaccineService.GetDetailsByCowId(cowId);
            if (result.IsSuccess == true)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("CowVaccinesGetDetailsByEntityId")]
        public IActionResult GetDetailsByEntityId(int id)
        {
            var result = _cowVaccineService.GetDetailsByEntityId(id);
            if (result.IsSuccess == true)
                return Ok(result);
            return BadRequest(result);
        }
    }
}

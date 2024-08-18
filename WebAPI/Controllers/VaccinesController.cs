using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VaccinesController : ControllerBase
    {
        IVaccineService _vaccineService;

        public VaccinesController(IVaccineService vaccineService)
        {
            _vaccineService = vaccineService;
        }

        [HttpPost("VaccinesAdd")]
        public IActionResult Add(Vaccine entity)
        {
            var result = _vaccineService.Add(entity);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("VaccinesGetAll")]

        public IActionResult GetAll()
        {
            var result = _vaccineService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("VaccinesUpdate")]

        public IActionResult Update(Vaccine entity)
        {
            var result = _vaccineService.Update(entity);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("VaccinesDelete")]
        public IActionResult Delete(Vaccine entity)
        {
            var result = _vaccineService.Delete(entity);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

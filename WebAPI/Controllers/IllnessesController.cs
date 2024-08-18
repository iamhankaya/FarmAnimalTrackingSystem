using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IllnessesController : ControllerBase
    {
        IIllnessService _illnessService;

        public IllnessesController(IIllnessService illnessService)
        {
            _illnessService = illnessService;
        }
        [HttpPost("IllnessesAdd")]
        public IActionResult Add(Illness illness)
        {
            var result = _illnessService.Add(illness);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("IllnessesGetAll")]

        public IActionResult GetAll()
        {
            var result = _illnessService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("IllnessesUpdate")]

        public IActionResult Update(Illness illness)
        {
            var result = _illnessService.Update(illness);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("IllnessesDelete")]
        public IActionResult Delete(Illness illness)
        {
            var result = _illnessService.Delete(illness);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

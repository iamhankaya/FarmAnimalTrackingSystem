using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CowsController : ControllerBase
    {

        ICowService _cowService;

        public CowsController(ICowService cowService)
        {
            _cowService = cowService;
        }

        [HttpPost("CowsAdd")]

        public IActionResult Add(Cow cow)
        {
            var result = _cowService.Add(cow);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("CowsGetAll")]

        public IActionResult GetAll()
        {
            var result = _cowService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("CowsUpdate")]

        public IActionResult Update(Cow cow)
        {
            var result = _cowService.Update(cow);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("CowsDelete")]
        public IActionResult Delete(Cow cow)
        {
            var result = _cowService.Delete(cow);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetCowsChildren")]

        public IActionResult GetCowsChildren(int id)
        {
            var result = _cowService.GetCowsChildren(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }


    }
}

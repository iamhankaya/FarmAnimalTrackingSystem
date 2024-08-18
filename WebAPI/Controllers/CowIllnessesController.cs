using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CowIllnessesController : ControllerBase
    {
        ICowIllnessService _cowIllnessService;

        public CowIllnessesController(ICowIllnessService cowIllnessService)
        {
            _cowIllnessService = cowIllnessService;
        }

        [HttpPost("CowIllnessesAdd")]
        public IActionResult Add(int cowId,int illnessId,string illnessDate)
        {
            var result = _cowIllnessService.AutoAdd(cowId, illnessId, illnessDate);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("CowIllnessesGetAll")]

        public IActionResult GetAll()
        {
            var result = _cowIllnessService.GetAll();
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("CowIllnessesUpdate")]

        public IActionResult Update(CowIllness entity)
        {
            var result = _cowIllnessService.Update(entity);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("CowIllnessesDelete")]

        public IActionResult Delete(CowIllness entity) 
        { 
            var result = _cowIllnessService.Delete(entity);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("CowIllnessesGetAllDetails")]
        public IActionResult GetAllDetails()
        {
            var result = _cowIllnessService.GetAllDetails();
            if (result.IsSuccess == true)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("CowIllnessesGetDetailsByCowId")]
        public IActionResult GetDetailsByCowId(int cowId)
        {
            var result = _cowIllnessService.GetDetailsByCowId(cowId);
            if (result.IsSuccess == true)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("CowIllnessesGetDetailsByEntityId")]
        public IActionResult GetDetailsByEntityId(int id)
        {
            var result = _cowIllnessService.GetDetailsByEntityId(id);
            if (result.IsSuccess == true)
                return Ok(result);
            return BadRequest(result);
        }
    }
}

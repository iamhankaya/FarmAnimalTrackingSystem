using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CowMedicinesController : ControllerBase
    {
        ICowMedicineService _cowMedicineService;

        public CowMedicinesController(ICowMedicineService cowMedicineService)
        {
            _cowMedicineService = cowMedicineService;
        }

        [HttpPost("CowMedicineAdd")]
        public IActionResult Add(int cowId, int medicineId, string medicineUsageStart,string medicineUsageEnd)
        {
            var result = _cowMedicineService.AutoAdd(cowId, medicineId, medicineUsageStart,medicineUsageEnd);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("CowMedicineGetAll")]

        public IActionResult GetAll()
        {
            var result = _cowMedicineService.GetAll();
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("CowMedicineUpdate")]

        public IActionResult Update(CowMedicine entity)
        {
            var result = _cowMedicineService.Update(entity);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("CowMedicineDelete")]
        public IActionResult Delete(CowMedicine entity)
        {
            var result = _cowMedicineService.Delete(entity);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("CowMedicineGetAllDetails")]
        public IActionResult GetAllDetails()
        {
            var result = _cowMedicineService.GetAllDetails();
            if (result.IsSuccess == true)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("CowMedicineGetDetailsByCowId")]
        public IActionResult GetDetailsByCowId(int cowId)
        {
            var result = _cowMedicineService.GetDetailsByCowId(cowId);
            if (result.IsSuccess == true)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("CowMedicineGetDetailsByEntityId")]
        public IActionResult GetDetailsByEntityId(int id)
        {
            var result = _cowMedicineService.GetDetailsByEntityId(id);
            if (result.IsSuccess == true)
                return Ok(result);
            return BadRequest(result);
        }
    }
}

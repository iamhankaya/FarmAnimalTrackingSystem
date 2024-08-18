using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicinesController : ControllerBase
    {
        IMedicineService _medicineService;

        public MedicinesController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        [HttpPost("MedicinesAdd")]
        public IActionResult Add(Medicine entity)
        {
            var result = _medicineService.Add(entity);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("MedicinesGetAll")]

        public IActionResult GetAll()
        {
            var result = _medicineService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("MedicinesUpdate")]

        public IActionResult Update(Medicine entity)
        {
            var result = _medicineService.Update(entity);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("MedicinesDelete")]
        public IActionResult Delete(Medicine entity)
        {
            var result = _medicineService.Delete(entity);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

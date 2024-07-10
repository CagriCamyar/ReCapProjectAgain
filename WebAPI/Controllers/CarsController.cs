using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarbybrandid")]
        public IActionResult GetByBrandId(int brandId) 
        {
            var result = _carService.GetByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarbycolourid")]
        public IActionResult GetByColourId(int colourId)
        {
            var result = _carService.GetByColourId(colourId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbydailyprice")]
        public IActionResult GetByDailyPrice(int dailyPriceMin, int dailyPriceMax)
        {
            var result = _carService.GetByDailyPrice(dailyPriceMin, dailyPriceMax);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("namemintwochars")]
        public IActionResult NameMinTwoChars(Car car)
        {   
            var result = _carService.NameMinTwoChars(car);
            if (result.Success)
            {
                return Ok(result);
            }
                return BadRequest(result);
        }

        [HttpGet("DailyPriceMoreThanZero")]
        public IActionResult DailyPriceMoreThanZero(Car car)
        {
            var result = _carService.DailyPriceMoreThanZero(car);
            if (result.Success)
            {
                return Ok(result);
            }          
                return BadRequest(result);
        }

        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addcar")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
             if (result.Success)
            {
                return Ok(result);
            }   
             return BadRequest(result);
        }
    }
}

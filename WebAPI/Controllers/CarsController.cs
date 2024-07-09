using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public IActionResult Get()
        {
            var result = _carService.GetAll();
            if (result.succes)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result.messages);

            }
        }


        [HttpPost]
        public IActionResult Post(Car car)
        {
            var result = _carService.add(car);
            if (result.succes)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.messages);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _carService.delete(id);
            if (result.succes)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.messages);
            }
        }


        [HttpPut]
        public IActionResult Put([FromBody]Car car)
        { 
            var result = _carService.update(car);
            if (result.succes)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.messages);
            }
        }
    }
}

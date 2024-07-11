using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        public RentalsController(IRentalService _rentalService)
        {
            this._rentalService = _rentalService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result=_rentalService.GetAll();
            if (result.succes)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.messages);
            }
        }

        [HttpGet("GetById")]
        public IActionResult Get(int id) 
        { 
        var result = _rentalService.Get(id);
            if (result.succes)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.messages);
            }
        
        }

        [HttpPost("Add")]
        public IActionResult Add(Rental rental) 
        {
            var result = _rentalService.add(rental);
            if (result.succes)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.messages);
            }
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var result = _rentalService.delete(id);
            if (result.succes)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result.messages);
            }
        }

        [HttpPut("Update")]
        public IActionResult update(Rental rental)
        {
            var result=_rentalService.update(rental);
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

using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService _customerService)
        {
            this._customerService = _customerService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() { 
        var result= _customerService.GetAll();
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
        public IActionResult Get(int id) { 
        var result= _customerService.Get(id);
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
        public IActionResult add(Customer customer)
        {
            var result = _customerService.add(customer);
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
        public IActionResult Delete(int id) { 
        var result =_customerService.delete(id);
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
        public IActionResult put(Customer customer) {
        var result=_customerService.update(customer);
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


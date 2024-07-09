using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService _brandService)
        {
            this._brandService = _brandService;
        }

        [HttpGet]
        public IActionResult Get() { 
        
        var result=_brandService.GetAll();
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
        public IActionResult Post(Brand brand) { 
        var result=_brandService.add(brand);
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

        public IActionResult Delete(int id) { 
        
        var result= _brandService.delete(id);
            if (result.succes) { 
            return Ok(result);
                
            }
            else
            { 
                return BadRequest(result.messages);
            }
        
        }

        [HttpPut]
        public IActionResult Put(Brand brand)
        {
            var result=_brandService.update(brand);
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

using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColourService _colourService;
        public ColorsController(IColourService _colourService)
        {
            this._colourService = _colourService;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var result = _colourService.GetAll();

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

        public IActionResult Post(Colour colour)
        {
            var result = _colourService.add(colour);

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
        var result = _colourService.delete(id);
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
        public IActionResult Put(Colour colour)
        {
            var result=_colourService.update(colour);

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

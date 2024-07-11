using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService _userService)
        {
            this._userService = _userService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() { 
            var result=_userService.GetAll();
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
        var result=_userService.Get(id);
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
        public IActionResult Get(User user) { 
        
        var result =_userService.add(user);
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
        var result=_userService.delete(id);
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
        public IActionResult Post(User user) 
        {
            var result=_userService.update(user);
            if(result.succes)
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

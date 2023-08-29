using BusinessLogicLayer.UserService.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dto_Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLeaveUser(Guid Id)
        {
            if(Id != Guid.Empty)
            {
                var allLeave= await _userService.GetParticularLeave(Id);
                return Ok(allLeave);
            }
            return NotFound("Id not be null");
        }

        [HttpPost("apply for leave")]

        public async Task<IActionResult> ApplyLeave(LeaveRequestDto model)
        {
            if (ModelState.IsValid)
            {
                await _userService.ApplyForLeave(model);
            }
            return BadRequest(ModelState);
        }

       
    }
}

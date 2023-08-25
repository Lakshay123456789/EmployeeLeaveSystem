using BusinessLogicLayer.AccountService.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dto_Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService) {
         
            _accountService = accountService;
        }
        [HttpPost("login")]

        public async Task<IActionResult> Login(UserLoginDto model)
        {
            if (ModelState.IsValid)
            {
                var result= await _accountService.LoginMethod(model);
                if (result.IsSuccess)
                {
                    return Ok(result);
                }
                return Unauthorized();
            }
            return NotFound();

        }
    }
}

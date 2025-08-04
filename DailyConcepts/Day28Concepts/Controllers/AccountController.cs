using Day28Concepts.Model;
using Day28Concepts.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Day28Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepostiory;

        public AccountController(IAccountRepository accountRepostiory)
        {
            _accountRepostiory = accountRepostiory;
        }

        [HttpPost("Signup")]
        public async Task<IActionResult> SignUp([FromBody] StudentModel studentModel)
        {
            var result = await _accountRepostiory.SignUpAsync(studentModel);
            {
                if (result.Succeeded)
                {
                    return Ok(result.Succeeded);
                }
                return Unauthorized();
            }

        }

        //[HttpPost("login")]
        //public async Task<IActionResult> Login([FromBody] SignInModel signInModel)
        //{
        //    var result = await _accountRepostiory.LoginAsync(signInModel);
        //    {
        //        if (string.IsNullOrEmpty(result)) 
        //        {
        //            return Unauthorized();
        //        }
        //        return Ok(result);
        //    }

        //}
    }
}

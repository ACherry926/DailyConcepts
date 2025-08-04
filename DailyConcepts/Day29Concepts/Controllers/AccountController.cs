using Day29Concepts.Model;
using Day29Concepts.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day29Concepts.Controllers
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
        public async Task<IActionResult> SignUp([FromBody] SignUpModel signUpModel)
        {
            var result = await _accountRepostiory.SignUpAsync(signUpModel);
            {
                if (result.Succeeded)
                {
                    return Ok(result.Succeeded);
                }
                return Unauthorized();
            }

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] SignInModel signInModel)
        {
            var result = await _accountRepostiory.LoginAsync(signInModel);
            {
                if (string.IsNullOrEmpty(result))
                {
                    return Unauthorized();
                }
                return Ok(result);
            }

        }
    }
}

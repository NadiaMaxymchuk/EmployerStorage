using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Token.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController:Controller
    {
        [Authorize]
        [Route("getlogin")]
        public IActionResult GetLogin()
        {
            return Ok($"Login: {User.Identity.Name}");
        }

        [Authorize(Roles = "Admin")]
        [Route("getrole")]
        public IActionResult GetRole()
        {
            return Ok("Administration");
        }
    }
}

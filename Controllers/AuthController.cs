using apiCadastro.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiCadastro.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if(username == "pablo" && password == "dutra")
            {
                var token = TokenService.GenerateToken(new Model.Pessoa());
                return Ok(token);
            }

            return BadRequest("Usuário e/ou senha inválidos.");
        }
    }
}

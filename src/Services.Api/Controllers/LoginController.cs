using Domain.Validations.Login;
using Microsoft.AspNetCore.Mvc;
using Services.Api.ViewModels;

namespace Services.Api.Controllers
{
    [ApiController]
    [Route("login")]
    public class LoginController : ControllerBase
    {
        [HttpPost("validar/senha")]
        public bool Post([FromBody] LoginViewModel loginViewModel)
        {
            var senha = loginViewModel.Senha;
            var loginValidation = new LoginValidation();
            bool senhaValidada = loginValidation.ValidarSenha(senha);

            return senhaValidada;
        }
    }
}

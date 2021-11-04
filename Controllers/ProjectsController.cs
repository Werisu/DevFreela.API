using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    /// <summary>
    /// Essa é uma Action, que é uma classe contida dentro do controle,
    /// que é uma interface implementada pelas respostas padrão do HTTP,
    /// como Ok, Not Found, etc
    /// </summary>
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            return Ok();
        }
    }
}
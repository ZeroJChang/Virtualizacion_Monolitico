using EjemploMonolitico.Clases;
using Microsoft.AspNetCore.Mvc;

namespace EjemploMonolitico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IntegrantesController : Controller
    {
        private readonly ILogger<IntegrantesController> _logger;

        public IntegrantesController(ILogger<IntegrantesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("Integrantes")]
        public ActionResult mostrarIntegrantes()
        {
            return Ok("Carlos Vargas, Ximena Elizardi y José De León");
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using EjemploMonolitico.Clases;

namespace EjemploMonolitico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : Controller
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("Suma")]
        public ActionResult Suma([FromBody] Numero numero)
        {
                return Ok(numero.op1 + numero.op2);
        }

        [HttpPost]
        [Route("Resta")]
        public ActionResult Resta([FromBody] Numero numero)
        {
            return Ok(numero.op1 - numero.op2);
        }

        [HttpPost]
        [Route("Multiplicaion")]
        public ActionResult Multiplicacion([FromBody] Numero numero)
        {
            return Ok(numero.op1 * numero.op2);
        }


        [HttpPost]
        [Route("Division")]
        public ActionResult Division([FromBody] Numero numero)
        {
            return Ok(numero.op1 / numero.op2);
        }
    }
}

using Juros.Utils;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JurosApi.Controllers
{
    [Route("taxaJuros")]
    [ApiController]
    public class TaxaDeJurosController : ControllerBase
    {
        // GET: api/<TaxaDeJurosController>
        [HttpGet]
        public double Get()
        {
            return Constantes.TaxaDeJuros;
        }
    }
}

using Juros.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JurosApi.Controllers
{
    [Route("calculajuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ITaxaDeJurosRestSharpService _taxaDeJurosRestSharpService;
        private readonly ICalculaJurosService _calculaJurosService;

        public CalculaJurosController(ITaxaDeJurosRestSharpService taxaDeJurosRestSharpService, 
                                        ICalculaJurosService calculaJurosService)
        {
            _taxaDeJurosRestSharpService = taxaDeJurosRestSharpService;
            _calculaJurosService = calculaJurosService;
        }

        // GET: api/<CalculaJurosController>
        [HttpGet]
        public string Get(double valorinicial, int meses)
        {
            var taxaDeJuros = _taxaDeJurosRestSharpService.GetTaxaDeJuros();

            return _calculaJurosService.CalculaJuros(valorinicial, taxaDeJuros, meses)
                    .ToString("N2");
        }
    }
}

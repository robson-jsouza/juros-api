using Juros.Services;
using Juros.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JurosApi.Controllers
{
    [Route("calculajuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosService _calculaJurosService;
        private readonly IHttpClientFactory _clientFactory;

        public CalculaJurosController( ICalculaJurosService calculaJurosService,
                                        IHttpClientFactory clientFactory)
        {
            _calculaJurosService = calculaJurosService;
            _clientFactory = clientFactory;
        }

        // GET: api/<CalculaJurosController>
        [HttpGet]
        public async Task<string> Get(double valorinicial, int meses)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
            Constantes.TaxaDeJurosURL);

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            double taxaDeJuros = 0;
            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                taxaDeJuros = await JsonSerializer.DeserializeAsync
                    <double>(responseStream);
            }

            return _calculaJurosService.CalculaJuros(valorinicial, taxaDeJuros, meses)
                    .ToString("N2");
        }
    }
}

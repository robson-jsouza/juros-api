using Juros.Utils;
using JurosApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace Juros.Testes
{
    public class TaxaDeJurosRestSharpServiceTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public TaxaDeJurosRestSharpServiceTests()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Test]
        public async Task AoChamarGetTaxaDeJurosObtemOValorCorretoDaTaxaAtual()
        {
            var response = await _client.GetAsync(Constantes.TaxaDeJurosURL);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();

            var taxaDaApi = 0D;
            double.TryParse(responseString, out taxaDaApi);
            var taxaEsperada = Constantes.TaxaDeJuros;

            Assert.AreEqual(taxaDaApi, taxaEsperada);
        }
    }
}
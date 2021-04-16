using Juros.Services;
using Juros.Utils;
using NUnit.Framework;

namespace Juros.Testes
{
    public class TaxaDeJurosRestSharpServiceTests
    {
        private ITaxaDeJurosRestSharpService _taxaDeJurosRestSharpService;

        [SetUp]
        public void Setup()
        {
            _taxaDeJurosRestSharpService = new TaxaDeJurosRestSharpService();
        }

        [Test]
        public void AoChamarGetTaxaDeJurosObtemOValorCorretoDaTaxaAtual()
        {
            var taxaDaApi = _taxaDeJurosRestSharpService.GetTaxaDeJuros();
            var taxaEsperada = Constantes.TaxaDeJuros;

            Assert.AreEqual(taxaDaApi, taxaEsperada);
        }
    }
}
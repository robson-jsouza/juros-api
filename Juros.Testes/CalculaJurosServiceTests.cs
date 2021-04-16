using Juros.Services;
using NUnit.Framework;

namespace Juros.Testes
{
    public class CalculaJurosServiceTests
    {
        private ICalculaJurosService _calculaJurosService;

        [SetUp]
        public void Setup()
        {
            _calculaJurosService = new CalculaJurosService();
        }

        [Test]
        public void AoChamarCalculaJurosComDeterminadosParametrosDeveRetornar105Virgula10100501000001()
        {
            var valorInicial = 100;
            var taxaDeJuros = 0.01;
            var meses = 5;

            var juros = _calculaJurosService.CalculaJuros(valorInicial, taxaDeJuros, meses);

            Assert.AreEqual(juros, 105.10100501000001);
        }

        [Test]
        public void AoChamarCalculaJurosComDeterminadosParametrosDeveRetornar110Virgula46221254112045()
        {
            var valorInicial = 100;
            var taxaDeJuros = 0.01;
            var meses = 10;

            var juros = _calculaJurosService.CalculaJuros(valorInicial, taxaDeJuros, meses);

            Assert.AreEqual(juros, 110.46221254112045);
        }
    }
}
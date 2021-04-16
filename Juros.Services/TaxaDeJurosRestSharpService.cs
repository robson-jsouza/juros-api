using Juros.Utils;
using RestSharp;
using System;

namespace Juros.Services
{
    public class TaxaDeJurosRestSharpService : ITaxaDeJurosRestSharpService
    {
        public double GetTaxaDeJuros()
        {
            var client = new RestClient(Constantes.TaxaDeJurosURL);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.ExecuteAsync(request).Result;

            double taxaDeJuros;
            Double.TryParse(response.Content, out taxaDeJuros);

            return taxaDeJuros;
        }
    }
}

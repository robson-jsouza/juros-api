using System;

namespace Juros.Services
{
    public class CalculaJurosService : ICalculaJurosService
    {
        public double CalculaJuros(double valorInicial, double taxaDeJuros, int meses)
        {
            return (valorInicial * Math.Pow(1 + taxaDeJuros, meses));
        }
    }
}

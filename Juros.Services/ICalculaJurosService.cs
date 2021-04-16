namespace Juros.Services
{
    public interface ICalculaJurosService
    {
        double CalculaJuros(double valorInicial, double taxaDeJuros, int meses);
    }
}

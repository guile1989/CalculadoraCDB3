using Bussiness.Interfaces;

namespace Bussiness.Services
{
    public class CalcularCDBService : ICalcularCDBService
    {
        public string CalcularCDB(double valorInicial, int qtdMeses)
        {
            if (valorInicial <= 0 || qtdMeses < 1)
            {
                return "Valor Inicial ou Quantidade de meses inválido!";
            }
            var calculadoraImpostoRenda = new CalcularImpostorendaService();
            var calculadoraInvestimentoCDB = new CalcularInvestimentoService();

            double valorAtual = valorInicial;

            for (int mes = 1; mes <= qtdMeses; mes++)
            {
                valorAtual = calculadoraInvestimentoCDB.CalcularInvestimento(valorAtual);
              
            }
            var valorBruto = valorAtual;
            var impostoRenda = calculadoraImpostoRenda.CalcularImpostoRenda(valorInicial, valorAtual, qtdMeses);
            var valorLiquido = valorAtual - impostoRenda;
            
            return $"Valor Bruto: {String.Format("{0:0.00}", valorBruto)} | Valor Líquido: {String.Format("{0:0.00}", valorLiquido)}";
        }
    }
}

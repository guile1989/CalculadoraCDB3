using Bussiness.Services;

namespace Business.Test.Tests
{
    public class CalcularCDBServiceTests
    {
        [Fact]
        public void CalcularCDB_ComValoresCorretos_RetornaResultadoCorreto()
        {
            var calcularCDBService = new CalcularCDBService();
            double valorInicial = 1000;
            int qtdMeses = 12; 

            var resultado = calcularCDBService.CalcularCDB(valorInicial, qtdMeses);

            Assert.Equal("Valor Bruto: 1123,08 | Valor Líquido: 1098,47", resultado); 
        }

        [Fact]
        public void CalcularCDB_ComValoresIncorretos_RetornaMensagemDeErro()
        {
            var calcularCDBService = new CalcularCDBService();
            double valorInicial = 0; 
            int qtdMeses = 6; 

            var resultado = calcularCDBService.CalcularCDB(valorInicial, qtdMeses);

            Assert.Equal("Valor Inicial ou Quantidade de meses inválido!", resultado);
        }
    }
}

using Bussiness.Services;

namespace Business.Test.Tests
{
    public class CalcularImpostoRendaServiceTests
    {
        [Theory]
        [InlineData(1000, 1200, 3, 45)] 
        [InlineData(2000, 2600, 9, 120)]     
        public void CalcularImpostoRenda_CalculaCorretamente(double valorInicial, double valorAtual, int mes, double impostoEsperado)
        {
            var calcularImpostorendaService = new CalcularImpostorendaService();

            var impostoCalculado = calcularImpostorendaService.CalcularImpostoRenda(valorInicial, valorAtual, mes);

            Assert.Equal(impostoEsperado, impostoCalculado, 2); // A precisão de 2 dígitos após a vírgula
        }
               

        [Fact]
        public void CalcularImpostoRenda_MaisDe24Meses_ComTaxaCorreta()
        {
            var calcularImpostorendaService = new CalcularImpostorendaService();

            var taxaImposto = calcularImpostorendaService.CalcularImpostoRenda(1000, 1300, 30);

            Assert.Equal(45, taxaImposto, 2);
        }
    }
}

using Bussiness.Services;

namespace Business.Test.Tests
{
    public class CalcularInvestimentoServiceTests
    {
        [Theory]
        [InlineData(1000, 1009.72)]
        [InlineData(2000, 2019.44)]
        public void CalcularInvestimento_CalcularCorretamente(double valorInicial, double valorFinalEsperado)
        {
            var calcularInvestimentoService = new CalcularInvestimentoService();

            var valorFinalCalculado = calcularInvestimentoService.CalcularInvestimento(valorInicial);

            Assert.Equal(valorFinalEsperado, valorFinalCalculado, 2);
        }
    }
}

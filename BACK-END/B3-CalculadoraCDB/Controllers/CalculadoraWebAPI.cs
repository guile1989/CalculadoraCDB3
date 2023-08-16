using Bussiness.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace B3_CalculadoraCDB.Controllers
{
    public class CalculadoraWebApi : Controller
    {
        private readonly ICalcularCDBService _calcularCDBService;
        public CalculadoraWebApi(ICalcularCDBService calcularCDBService)
        {
            _calcularCDBService = calcularCDBService;
        }

        [HttpGet("CalcularCDB")]
        public ActionResult<string> CalcularCDB(double valorInicial, int qtdMeses)
        {
            var response = _calcularCDBService.CalcularCDB(valorInicial, qtdMeses);

            if (response == "Valor Inicial ou Quantidade de meses inválido!")
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}

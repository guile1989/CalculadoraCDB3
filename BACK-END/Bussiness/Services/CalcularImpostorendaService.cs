﻿namespace Bussiness.Services
{
    public class CalcularImpostorendaService
    {
        public double CalcularImpostoRenda(double valorInicial, double valorAtual, int mes)
        {
            double lucro = valorAtual - valorInicial;
            double taxaImposto;

            if (mes <= 6)
                taxaImposto = 0.225;
            else if (mes <= 12)
                taxaImposto = 0.20;
            else if (mes <= 24)
                taxaImposto = 0.175;
            else
                taxaImposto = 0.15;

            double imposto = lucro * taxaImposto;
            return imposto;
        }
    }
}

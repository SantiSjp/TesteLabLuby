using System;
using System.Globalization;

namespace LogicaDeProgramacao._6_DiferencaData
{
    public class DiferencaData
    {
        public double resultado = 0;

        public double CalcularDiferencaData(string dataInicial, string dataFinal)
        {
            DateTime inicio = DateTime.ParseExact(dataInicial, "ddMMyyyy", CultureInfo.InvariantCulture);
            DateTime fim = DateTime.ParseExact(dataFinal, "ddMMyyyy", CultureInfo.InvariantCulture);

            var resultado = fim.Subtract(inicio).TotalDays;

            return resultado;
        }
    }
}

using System;

namespace LogicaDeProgramacao._5_Desconto
{
    public class Desconto
    {
        public string resultado = "";

        public string CalcularValorComDescontoFormatado(string preco, string desconto)
        {
            var precoConvertido = Double.Parse(preco.Substring(3));
            var descontoConvertido = Double.Parse(desconto.Substring(0, 2));
            resultado = (precoConvertido - (precoConvertido * (descontoConvertido / 100))).ToString("N2");

            return resultado;

        }
    }
}

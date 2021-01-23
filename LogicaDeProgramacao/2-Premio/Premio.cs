
using System;

namespace LogicaDeProgramacao._2_Premio
{
    public class Premio
    {
        public double valorFinal = 0;
        public double CalcularPremio(double premio, string tipoDoPremio, dynamic fatorProprio = null)
        {
            try
            {
                if (premio < 0 || fatorProprio < 0) 
                { 
                    throw new Exception("Valores informados nao podem ser negativos!"); 
                }

                if (tipoDoPremio == "basic")
                {
                    valorFinal =  fatorProprio > 0 ? premio * 1 * fatorProprio : premio * 1;
                }else if (tipoDoPremio == "vip")
                {
                    valorFinal = fatorProprio > 0 ? premio * 1.2 * fatorProprio : premio * 1.2;
                }
                else if (tipoDoPremio == "premium")
                {
                    valorFinal = fatorProprio > 0 ? premio * 1.5 * fatorProprio : premio * 1.5;
                }
                else if (tipoDoPremio == "deluxe")
                {
                    valorFinal = fatorProprio > 0 ? premio * 1.8 * fatorProprio : premio * 1.8;
                }
                else if (tipoDoPremio == "special")
                {
                    valorFinal = fatorProprio > 0 ? premio * 2 * fatorProprio : premio * 2;
                }
                else
                {
                    throw new Exception("Tipo de fator do premio invalido!");
                }

                return valorFinal;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
                return 0;
            }           
            
        }

    }
}

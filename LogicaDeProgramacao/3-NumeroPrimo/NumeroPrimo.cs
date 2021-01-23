using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao._3_NumeroPrimo
{
    public class NumeroPrimo
    {

        public double resultado = 0;
        public double ContarNumerosPrimos(double valor)
        {
            for (int i = 2; i <= valor; i++)
            {
                if (IsPrimo(i))
                {
                    resultado++;
                }
            }
            return resultado;
        }

        static public bool IsPrimo(double valor)
        {
            for (int i = 2; i < valor; i++)
            {
                if (valor % i == 0) return false; // não é primo.
            }
            return true; //é primo
        }
    }
}

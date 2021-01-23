using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao._4_Vogais
{
    public class Vogais
    {
        public double resultado = 0;

        public double CalcularVogais(string texto)
        {
            foreach (var letra in texto.ToUpper())
            {
                if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                {
                    resultado++;
                }               
            }
            return resultado;
        }

    }
}

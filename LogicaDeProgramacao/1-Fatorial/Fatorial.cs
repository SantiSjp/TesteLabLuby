using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao._1_Fatorial
{
    public  class Fatorial
    {
        public double CalcularFatorial(double valor)
        {
            if (valor == 1 || valor == 0)
                return 1;
            else
                return valor * CalcularFatorial(valor - 1);
        }
    }
}

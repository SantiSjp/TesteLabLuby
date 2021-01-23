using System.Collections.Generic;

namespace LogicaDeProgramacao._7_ElementosPares
{
    public class ElementosPares
    {       
        public int[] ObterElementosPares(int[] array)
        {
            var pares = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    pares.Add(array[i]);
                }
            }
            var resultado = pares.ToArray();
            return resultado;
        }
    }
}

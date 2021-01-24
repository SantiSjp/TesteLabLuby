using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao._10_ElementosFaltantes
{
    public class ElementosFaltantes
    {
        public int[] ObterElementosFaltantes(int[] array1, int[] array2)
        {
            var resultList = new List<int>();
            var indiceEncontrado = new List<int>();
            var maiorArray = ObterMaiorArray(array1, array2);
            var menorArray = ObterMenorArray(array1, array2);

            for (int i = 0; i < maiorArray.Length; i++)
            {
                for (int j = 0; j < menorArray.Length; j++)
                {
                    if (maiorArray[i] == menorArray[j])
                    {
                        indiceEncontrado.Add(i);
                    }                      
                }                
            }

            for (int i = 0; i < array1.Length; i++)
            {
                var existeIndice = indiceEncontrado.Contains(i);

                if (!existeIndice)
                {
                    resultList.Add(array1[i]);
                }
            }

            var result = resultList.ToArray();
            return result;
        }

        public int[] ObterMaiorArray(int[] array1, int[] array2)
        {
            if (array1.Length > array2.Length) 
            {
                return array1;
            }else if (array2.Length > array1.Length)
            {
                return array2;
            }
            else { return array1; }
        }

        public int[] ObterMenorArray(int[] array1, int[] array2)
        {
            if (array1.Length < array2.Length)
            {
                return array1;
            }
            else if (array2.Length < array1.Length)
            {
                return array2;
            }
            else { return array2; }
        }

    }
}

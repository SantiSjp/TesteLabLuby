using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaDeProgramacao._8_ElementosArray
{
    public class ElementosArray
    {

        public string[] BuscarPessoa(string[] array, string pessoa)
        {
            var arrayToList = new List<string>();
            foreach (var item in array)
            {
                arrayToList.Add(item);
            }

            var resultado = arrayToList.Where(x => x.Contains(pessoa));
            return resultado.ToArray();
        }
    }
}

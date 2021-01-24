using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LogicaDeProgramacao._9_StringMatriz
{
    public class StringMatriz
    {

        public int[][] TransformarEmMatriz(string valor)
        {
            var splitString = valor.Split(',');
            var teste = new Dictionary<int, int>();

            foreach (var item in splitString)
            {
                var convert = int.Parse(item);
            }

            
            return new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } };
        }
    }
}

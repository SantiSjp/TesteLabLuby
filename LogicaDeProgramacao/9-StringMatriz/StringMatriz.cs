using System.Collections.Generic;

namespace LogicaDeProgramacao._9_StringMatriz
{
    public class StringMatriz
    {
        public int[][] TransformarEmMatriz(string valor)
        {
            var splitString = valor.Split(',');
            var resultList = new List<int[]>();
            var auxList = new List<int>();

            for (int i = 0; i < splitString.Length; i++)
            {
                if (i != 0 && i % 2 != 0)
                {
                    auxList.Add(int.Parse(splitString[i - 1]));
                    auxList.Add(int.Parse(splitString[i]));
                    resultList.Add(auxList.ToArray());
                    auxList.Clear();
                }

                if (i == splitString.Length - 1 && i % 2 == 0)
                {
                    auxList.Add(int.Parse(splitString[i]));
                    resultList.Add(auxList.ToArray());
                    auxList.Clear();
                }

            }
            var result = resultList.ToArray();
            return result;
        }
    }
}

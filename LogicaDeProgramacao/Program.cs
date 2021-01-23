using LogicaDeProgramacao._1_Fatorial;
using LogicaDeProgramacao._2_Premio;
using LogicaDeProgramacao._3_NumeroPrimo;
using LogicaDeProgramacao._4_Vogais;
using LogicaDeProgramacao._5_Desconto;
using LogicaDeProgramacao._6_DiferencaData;
using LogicaDeProgramacao._7_ElementosPares;
using LogicaDeProgramacao._8_ElementosArray;
using System;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main()
        {
            // 1 - Calcula Fatorial
            Console.WriteLine("----- 1 - Calcula Fatorial -----");
            var fatorial = new Fatorial();
            var valorFatorial = 5;
            var resultadoFatorial = fatorial.CalcularFatorial(valorFatorial);
            Console.WriteLine("O Fatorial de " + valorFatorial + " eh: " + resultadoFatorial);
            Console.WriteLine("");

            // 2 - Calcula Premio
            Console.WriteLine("----- 2 - Calcula Premio -----");
            var premio = new Premio();
            var resultadoPremio = premio.CalcularPremio(22, "basic", null);
            Console.WriteLine("O valor final eh: " + resultadoPremio);
            Console.WriteLine("");

            // Calcula Numero Primo
            Console.WriteLine("----- 3 - Calcula Numero Primo -----");
            var numeroPrimo = new NumeroPrimo();
            var valorPrimo = 10;
            var resultadoPrimo = numeroPrimo.ContarNumerosPrimos(valorPrimo);
            Console.WriteLine("A quantidade de numeros primos até "+ valorPrimo + " eh: "+resultadoPrimo);
            Console.WriteLine("");

            // Calcula Vogais
            Console.WriteLine("----- 4 - Calcula Vogais -----");
            var vogais = new Vogais();
            var valorVogais = "Luby Software";
            var resultadoVogais = vogais.CalcularVogais(valorVogais);
            Console.WriteLine("A quantidade de de vogais da string '" + valorVogais + "' eh: " + resultadoVogais);
            Console.WriteLine("");

            // Calcula Desconto
            Console.WriteLine("----- 5 - Calcula Desconto -----");
            var desconto = new Desconto();
            var valorPreco = "R$ 6.800,00";
            var valorDesconto = "30%";
            var resultadoDesconto = desconto.CalcularValorComDescontoFormatado(valorPreco, valorDesconto);
            Console.WriteLine("O valor " + valorPreco + " Com desconto de " + valorDesconto + " fica igual a: R$ " + resultadoDesconto);
            Console.WriteLine("");

            // Calcula Diferenca Datas
            Console.WriteLine("----- 6 - Calcula Diferenca Datas -----");
            var diferencaData = new DiferencaData();
            var valorDataInicio = "10122020";
            var valorDataFim = "25122020";
            var resultadoData = diferencaData.CalcularDiferencaData(valorDataInicio, valorDataFim);
            Console.WriteLine("A diferenca das datas em dias eh: " + resultadoData + " dias");
            Console.WriteLine("");

            // Calcula Elementos Pares
            Console.WriteLine("----- 7 - Calcula Elementos Pares -----");
            var elementosPares = new ElementosPares();
            var arrayDeElementos = new int[] { 1, 2, 3, 4, 5 };
            var resultadoPares = elementosPares.ObterElementosPares(arrayDeElementos);
            Console.WriteLine("Os elementos pares do array informado são:");
            foreach (var item in resultadoPares)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


            // Calcula Elementos Array
            Console.WriteLine("----- 8 - Calcula Elementos Array -----");
            var elementosArray = new ElementosArray();
            var arrayDeNomes = new string[] {
                "John Doe",
                "Jane Doe",
                "Alice Jones",
                "Bobby Louis",
                "Lisa Romero"
            };
            var resultadoElementos = elementosArray.BuscarPessoa(arrayDeNomes);
            foreach (var item in resultadoElementos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
    }
}

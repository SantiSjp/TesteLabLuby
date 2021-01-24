using _3DesafioPOO.MaquinaVendas;
using System;
using System.Collections.Generic;

namespace _3DesafioPOO
{
    class Program
    {
        static void Main()
        {
            var listaDeProduto = new List<Produto>();
            var maquina = new Maquina(listaDeProduto);
            InserirProdutos(maquina);

            Console.WriteLine("----- MAQUINA DE BEBIDAS -----");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Listar Estoque");
            Console.WriteLine();
           
            while (true)
            {
                Console.Write("Digite uma Opcao: ");
                var opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    case "0":
                        Console.WriteLine("Saindo...");
                        Console.WriteLine();
                        return;
                    case "1":
                        Console.WriteLine("----- Listar Estoque -----");
                        foreach (var item in maquina.Produto)
                        {
                            Console.WriteLine("Produto: " + item.Nome + " - Preco: R$ " + item.Valor.ToString("N2") + " - Quantidade: " + item.Quantidade);
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida!");
                        break;
                }
            }

            static void InserirProdutos(Maquina maquina)
            {

                var p1 = new Produto("CocaCola", 2.50, 5);
                var p2 = new Produto("Fanta Uva", 1.50, 2);
                var p3 = new Produto("Gatorade", 3.50, 10);

                maquina.Produto.Add(p1);
                maquina.Produto.Add(p2);
                maquina.Produto.Add(p3);

            }
        }
    }
}

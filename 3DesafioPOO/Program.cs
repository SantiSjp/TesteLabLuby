using _3DesafioPOO.MaquinaVendas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3DesafioPOO
{
    class Program
    {
        static void Main()
        {
            var listaDeProduto = new List<Produto>();
            var maquina = new Maquina(listaDeProduto);

            InserirProdutos(maquina);
            MostrarMenu();
            
            while (true)
            {
                Console.Write("Digite uma Opcao: ");
                var opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    // Sair
                    case "0":
                        Console.WriteLine("Saindo...");
                        Console.WriteLine();
                        return;

                    // Mostrar Estoque
                    case "1":
                        Console.WriteLine("----- Listar Estoque -----");
                        MostrarEstoque(maquina);
                        break;

                    // Realizar Venda
                    case "2":
                        Console.WriteLine("----- Realizar Venda -----");
                        MostrarEstoque(maquina);
                        Console.Write("Selecione um produto pelo Id:");                        
                        var idProduto = Console.ReadLine();                        
                        var produtoParaVenda = maquina.Produto
                            .Where(x => x.Id == int.Parse(idProduto))
                            .FirstOrDefault();
                        if (produtoParaVenda == null)
                        {
                            Console.Clear();
                            Console.WriteLine("Produto Invalido");
                            MostrarMenu();
                            break;
                        }
                        Console.Write("Informe a Quantidade:");
                        var quantidade = Console.ReadLine();
                        if (int.Parse(quantidade) > produtoParaVenda.Quantidade)
                        {
                            Console.Clear();
                            Console.WriteLine("Quantidade Maior do que Disponível no estoque");
                            MostrarMenu();
                            break;
                        }

                        Console.Write("Informe o valor recebido em R$ (sem virgula): ");
                        var valorRecebido = Console.ReadLine();

                        if (double.Parse(valorRecebido) < produtoParaVenda.Valor * int.Parse(quantidade))
                        {
                            var faltante = produtoParaVenda.Valor * int.Parse(quantidade) - double.Parse(valorRecebido);
                            while (true)
                            {
                                Console.WriteLine("Ainda falta receber R$: " + faltante.ToString("N2"));

                                Console.Write("Informe o valor faltante recebido em R$ (sem virgula): ");
                                var valorFaltanteRecebido = Console.ReadLine();

                                if (double.Parse(valorFaltanteRecebido) >= faltante)
                                {
                                    Console.WriteLine("O troco deve ser de R$: " + (double.Parse(valorFaltanteRecebido) - faltante).ToString("N2"));
                                    break; 
                                }

                                faltante -= double.Parse(valorFaltanteRecebido);

                            }
                        }     
                            

                        maquina.ValorTotalDeVenda += produtoParaVenda.Valor * int.Parse(quantidade);
                        maquina.Produto
                            .Where(x => x.Id == int.Parse(idProduto))
                            .FirstOrDefault()
                            .Quantidade -= int.Parse(quantidade);

                        Console.WriteLine("Venda do Produto " + produtoParaVenda.Nome 
                            + " Concluida com " + int.Parse(idProduto)
                            + " unidades vendidas");

                        break;

                    case "3":
                        Console.WriteLine("----- Valor Total de Vendas -----");
                        var valorTotal = maquina.ValorTotalDeVenda;
                        Console.WriteLine("Valor Total de Vendas foi de R$ " + valorTotal.ToString("N2"));
                        break;

                    // Opcao Errada
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcao Invalida!");
                        MostrarMenu();
                        break;
                }
            }

            static void InserirProdutos(Maquina maquina)
            {

                var p1 = new Produto(1, "CocaCola", 2.50, 5);
                var p2 = new Produto(2, "Fanta Uva", 1.50, 2);
                var p3 = new Produto(3, "Gatorade", 3.50, 10);

                maquina.Produto.Add(p1);
                maquina.Produto.Add(p2);
                maquina.Produto.Add(p3);

            }

            static void MostrarMenu()
            {
                Console.WriteLine("----- MAQUINA DE BEBIDAS -----");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Listar Estoque");
                Console.WriteLine("2 - Realizar Venda");
                Console.WriteLine("3 - Mostrar Valor Total de Vendas");
                Console.WriteLine("-------------------------------");
                Console.WriteLine();
            }

            static void MostrarEstoque(Maquina maquina)
            {
                foreach (var item in maquina.Produto)
                {
                    Console.WriteLine("Id: " + item.Id + " -  Produto: "
                        + item.Nome + " - Preco: R$ "
                        + item.Valor.ToString("N2") + " - Quantidade: "
                        + item.Quantidade);
                }
                Console.WriteLine();
            }
        }
    }
}

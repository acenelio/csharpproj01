using System;
using System.Collections.Generic;

namespace curso {
    class Program {

        public static List<Produto> produtos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();

        static void Main(string[] args) {

            int opcao = 0;

            produtos.Add(new Produto(1001, "Cadeira simples", 500.00));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new Produto(1003, "Sofá de três lugares", 2000.00));
            produtos.Add(new Produto(1004, "Mesa redonda", 1500.00));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));

            while (opcao != 5) {
                Console.Clear();
                Tela.mostrarMenu();
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opcao == 1) {
                    Tela.mostrarProdutos();
                }
                else if (opcao == 2) {
                    try {
                        Produto P = Tela.lerProduto();
                        produtos.Add(P);
                    }
                    catch (NegocioException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 3) {
                    try {
                        Pedido P = Tela.lerPedido();
                        pedidos.Add(P);
                    }
                    catch (NegocioException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 4) {
                    try {
                        Tela.mostrarPedido();
                    }
                    catch (NegocioException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 5) {
                    Console.WriteLine("Fim do programa!");
                }
                else {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Globalization;

namespace curso {

    // Classe responsavel por conter operações que interagem com o usuário
    // no modo console

    class Tela {
        public static void mostrarMenu() {
            Console.WriteLine("1 - Listar produtos");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Cadastrar pedido");
            Console.WriteLine("4 - Mostrar dados de um pedido");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");
        }

        public static void mostrarProdutos() {
            Console.WriteLine("LISTAGEM DE PRODUTOS:");
            for (int i = 0; i < Program.produtos.Count; i++) {
                Console.WriteLine(Program.produtos[i]);
            }
            Console.WriteLine();
        }

        public static Produto lerProduto() {
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return new Produto(codigo, descricao, preco);
        }

        public static Pedido lerPedido() {
            Console.WriteLine("Digite os dados do pedido: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Pedido P = new Pedido(codigo, dia, mes, ano);
            Console.Write("Quantos itens tem o pedido: ");
            int N = int.Parse(Console.ReadLine());
            for (int i=1; i<=N; i++) {
                Console.WriteLine("Digite os dados do " + i + "° item:");
                Console.Write("Produto (código): ");
                int codProduto = int.Parse(Console.ReadLine());
                int pos = Program.produtos.FindIndex(x => x.codigo == codProduto);
                if (pos == -1) {
                    throw new NegocioException("Código de produto não encontrado: " + codProduto);
                }
                Console.Write("Quantidade: ");
                int qte = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de desconto: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ItemPedido ip = new ItemPedido(qte, porcent, P, Program.produtos[pos]);
                P.itens.Add(ip);
            }
            return P;
        }

        public static void mostrarPedido() {
            Console.Write("Digite o código do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.codigo == codPedido);
            if (pos == -1) {
                throw new NegocioException("Código de pedido não encontrado: " + codPedido);
            }
            Console.WriteLine(Program.pedidos[pos]);
            Console.WriteLine();
        }
    }
}

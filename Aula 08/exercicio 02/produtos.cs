namespace exercicio_2

{   using System;
    using System.Net;
    using System.Security.Cryptography.X509Certificates;
    public struct produto
    {
        public string nome;
        public int codigo;
        public double preco;
        public int quantidade;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            produto[] produtos = new produto[3];

            for (int i = 0; i<3; i++)
            {
                Console.WriteLine("======= lojinha da shoppe ===========");

                Console.WriteLine($"digite o nome do produto {i + 1}:");
                produtos[i].nome = Console.ReadLine();
               
                Console.WriteLine("digite o codigo do produto:");
                produtos[i].codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("digite o preço do produto:");
                produtos[i].preco = double.Parse(Console.ReadLine());

                Console.WriteLine("digite a quantidade desse produto:");
                produtos[i].quantidade = int.Parse(Console.ReadLine());
                     
            }

            Console.WriteLine("==== carrinho total da shoppe =======");
            double totaldeproduto = 0;
            for( int i = 0; i<3; i++)
            {
                Console.WriteLine(produtos[i].nome);
                totaldeproduto += produtos[i].preco * produtos[i].quantidade;
            }
            Console.WriteLine($"o valor total é de {totaldeproduto}");
            return 0;
        }
    }
}

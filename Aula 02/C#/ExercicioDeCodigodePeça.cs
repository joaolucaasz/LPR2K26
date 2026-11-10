using System;

class Program
{
    static void Main(string[] args)
 {   
    Console.Write("Digite o código da peça 1: ");
        int codigo1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de peças 1: ");
        int quantidade1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor unitário da peça 1: ");
        double valor1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o código da peça 2: ");
        int codigo2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de peças 2: ");
        int quantidade2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor unitário da peça 2: ");
        double valor2 = double.Parse(Console.ReadLine());
        
        double total = (quantidade1* valor1) + (quantidade2 * valor2);  
        Console.WriteLine($"\nValor a pagar: R$ {total:F2}");
    }
}
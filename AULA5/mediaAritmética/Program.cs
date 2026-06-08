using System;

class Program
{
    static void Main()
    {
        int quantidade, contador = 0;
        int numero, soma = 0, quantidadeDePares = 0;

        Console.Write("Quantos números você vai digitar? ");
        quantidade = int.Parse(Console.ReadLine());

        while (contador < quantidade)
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) 
            {
                soma += numero;
                quantidadeDePares++;
            }

            contador++;
        }

        if (quantidadeDePares > 0)
        {
            double media = (double)soma / quantidadeDePares;
            Console.WriteLine("Média dos pares: " + media);
        }
        else
        {
            Console.WriteLine("Nenhum número par foi digitado.");
        }
    }
}
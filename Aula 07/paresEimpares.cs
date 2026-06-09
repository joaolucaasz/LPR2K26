using System;

class ExemploVetor
{
    static void Main()
    {
        int[] numeros = new int[10];
        int[] pares = new int[10];
        int[] impares = new int[10];

        int qtdPares = 0;
        int qtdImpares = 0;

        Console.WriteLine("Digite 10 números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                pares[qtdPares] = numeros[i];
                qtdPares++;
            }
            else
            {
                impares[qtdImpares] = numeros[i];
                qtdImpares++;
            }
        }

        Console.WriteLine("\nNúmeros pares:");
        for (int i = 0; i < qtdPares; i++)
        {
            Console.Write(pares[i] + " ");
        }

        Console.WriteLine("\n\nNúmeros ímpares:");
        for (int i = 0; i < qtdImpares; i++)
        {
            Console.Write(impares[i] + " ");
        }
    }
}
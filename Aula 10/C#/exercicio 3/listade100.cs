using System;
using System.Collections.Generic;
//Construa uma lista de 100 números aleatórios Crie um algoritmo que coloque-os em 
//ordem crescente e imprima-os
//A partir dessa lista ordenada, remova todos 
//os números pares e imprima a lista 
//novamente.
//Por fim imprima quais números se repetem, 
//se existe algum número repetido.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random random = new Random();

        List<int> numeros = new List<int>();

       
        for (int i = 0; i < 100; i++)
        {
            numeros.Add(random.Next(1, 101));
        }

    
        for (int i = 0; i < numeros.Count - 1; i++)
        {
            for (int j = 0; j < numeros.Count - i - 1; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int aux = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = aux;
                }
            }
        }
       
        Console.WriteLine("Lista em ordem crescente:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("\n");

        
        while (numeros.Exists(x => x % 2 == 0))
        {
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    numeros.RemoveAt(i);
                    break;
                }
            }
        }
     
        Console.WriteLine("Lista sem os números pares:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("\n");

    
        Console.WriteLine("Números repetidos:");

        bool encontrou = false;

        for (int i = 0; i < numeros.Count; i++)
        {
            int repeticoes = 0;

            foreach (int numero in numeros)
            {
                if (numero == numeros[i])
                    repeticoes++;
            }

            bool jaMostrou = false;

            for (int j = 0; j < i; j++)
            {
                if (numeros[j] == numeros[i])
                {
                    jaMostrou = true;
                    break;
                }
            }

            if (repeticoes > 1 && !jaMostrou)
            {
                Console.WriteLine(numeros[i]);
                encontrou = true;
            }
        }
        if (!encontrou)
        {
            Console.WriteLine("Não existem números repetidos.");
        }
    }
}
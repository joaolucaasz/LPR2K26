using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
 
    List<string> nomes = new List<string>();

    for (int i = 0; i < x; i++)
        {
            nomes.Add(Console.ReadLine());
        }
  
        int maior = 0;
        foreach (string nome in nomes)
        {
            if (nome.Length > maior)
                maior = nome.Length;
        }

        int linha = 0;

        while (true)
        {
            bool temnome = false;
            for (int tam = 1; tam <= maior; tam++)
            {
                int cont = 0;

                foreach (string nome in nomes)
                {
                    if (nome.Length == tam)
                    {
                        if (cont == linha)
                        {
                            Console.Write(nome + " ");
                            temnome = true;
                            break;
                        }
                        cont++;
                    }
                }
            }

            if (!temnome)
                break;

            Console.WriteLine();
            linha++;
        }
    }
}
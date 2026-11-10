namespace Aula_09
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.Metrics;
    using System.Linq;
    using System.Runtime.ConstrainedExecution;
    using System.Runtime.Serialization;

    internal class Program
    {
        //Construa uma lista de X nomes  aleatórios

        // A saída deve ser mostrada em uma ou mais
        // linhas.Cada linha tem uma lista de nomes
        //  ordenados por tamanho, começando com
        //  o menor.Em cada linha, só pode ser
        //  mostrado um nome de determinado
         //  tamanho, e os demais nomes com o
         // mesmo tamanho devem ser apresentadosnas linhas seguintes.Você deve seguir a ordem de digitação.

        static void Main(string[] args)
        {
            Console.Write("Quantidade de nomes: ");
            int x = int.Parse(Console.ReadLine());

            List <string> nomes = new List<string>();

            Console.WriteLine("Digite os nomes:");

            for (int i = 0; i < x; i++)
            {
              nomes.Add(Console.ReadLine());
            }

            
            List <int> tamanhos = new List <int>();

            foreach (string nome in nomes)
            {
            if (!tamanhos.Contains(nome.Length))
           tamanhos.Add(nome.Length);
            }
            tamanhos.Sort();

            bool existemNomes = true;
            while (existemNomes)
            {
                existemNomes = false;
                List<string> linha = new List <string>();

                foreach (int tamanho in tamanhos)
                {
                  for (int i = 0; i < nomes.Count; i++)
                    {
                    if (nomes[i] != null && nomes[i].Length == tamanho)
                        {
                      linha.Add(nomes[i]);
                            existemNomes = true;                                
                                break; 
                        }
                    }
                }       
            }
        }
    }
    
}
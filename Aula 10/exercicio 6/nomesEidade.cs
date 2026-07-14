//Construa um dicionário de X pares chave-valor onde as chaves são nomes de 
// pessoas e os valores são suas respectivas idades.
//Encontre e imprima todos os nomes de pessoas 
//com idade acima da média.
//Encontre e imprima o nome da pessoa mais 
//velha e o nome da pessoa mais nova.
//Remova todas as pessoas com idade igual a um 
//valor Y (fornecido pelo usuário) e imprima o 
//dicionário atualizado 

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, int> pessoas  = new Dictionary<string, int>();

        Console.WriteLine("Digite a quantidade de pessoas:");
        int x = int.Parse(Console.ReadLine());

        for ( int i = 0; i< x; i++)
        {
            Console.Write($"\nnome da pessoa {i + 1 }:");
            string nome = Console.ReadLine();

            Console.Write("idade");
            int idade = int.Parse(Console.ReadLine());

            pessoas[nome] = idade;
 
        }
         double media = pessoas.Values.Average();

         Console.WriteLine($"\nA média de idade é: {media:F2}");

         Console.WriteLine("\n pessoas com idade acima da média:");
         foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > media)
            {
                Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos ");
            }
        }
         int maiordeidade = pessoas.Values.Max();
         foreach (var pessoa in pessoas)
        {
            if (pessoa.Value == maiordeidade)
            {
                Console.WriteLine ($"pessoa mais velha: {pessoa.Key} ({pessoa.Value} anos)");
                break;
            }
        }
        int menordeidade = pessoas.Values.Min();
        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value == menordeidade)
            {
                Console.WriteLine ($"pessoa mais nova: {pessoa.Key} ({pessoa.Value} anos)");
                break;
            }
        }
        Console.Write("\nDigite a idade que deseja remover: ");
        int y = int.Parse(Console.ReadLine());

        List<string> remover = new List<string>();

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value == y)
            {
                remover.Add(pessoa.Key);
            }
        }

        foreach (string nome in remover)
        {
            pessoas.Remove(nome);
        }

        Console.WriteLine("\ndicionário atualizado:");

        if (pessoas.Count == 0)
        {
            Console.WriteLine("nenhuma pessoa cadastrada.");
        }
        else
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos");
            }
        }
    }
}
    



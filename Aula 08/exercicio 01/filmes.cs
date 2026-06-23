using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

public struct filme
{
    public string titulo;
    public string diretor;
    public int anoLançamento;
    public int duração;

    class Program
    {
        static void Main()
        {
            filme[] filmes = new filme[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"filme {i + 1}");
                Console.Write("titulo:");
                filmes[i].titulo = Console.ReadLine();
                Console.WriteLine("Diretor:");
                filmes[i].diretor = Console.ReadLine();
                Console.WriteLine("ano lançado");
                filmes[i].anoLançamento = int.Parse(Console.ReadLine());
                Console.WriteLine("duração do filme");
                filmes[i].duração = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("==== filme cadastradoss ====");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"titulo: {filmes[i].titulo}");
                Console.WriteLine($"diretor: {filmes[i].diretor}");
                Console.WriteLine($"ano de lancamento: {filmes[i].anoLançamento}");
                Console.WriteLine($"duracao: {filmes[i].duração}");

            }
            filme mais_antigo = filmes[0];
            for (int i = 1; i < 3; i++)
            {
                if (filmes[i].anoLançamento < mais_antigo.anoLançamento)
                {
                    mais_antigo = filmes[i];
                }
            }
            Console.WriteLine("filme mais antigo:");
            Console.WriteLine($"titulo:{ mais_antigo.titulo}");
            Console.WriteLine($"ano de lançamento: {mais_antigo.anoLançamento}");
            return 0;
        }
        }
       
    }


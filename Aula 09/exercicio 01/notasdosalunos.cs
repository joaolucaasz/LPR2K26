namespace Aula_09
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    internal class Program
    {
        //Crie um programa que permita
        //ao usuário cadastrar notas de alunos em
        //uma lista.O programa deve:
        //Solicitar ao usuário 5 notas.
        //Armazenar as notas em uma lista.
        //● Exibir:
        //○ Todas as notas cadastradas;
        //○ A maior nota;
        //○ A menor nota;
        //○ A média das notas

        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"digite a {i} nota:");
                double nota = Convert.ToDouble(Console.ReadLine());

                notas.Add(nota);
            }
            Console.WriteLine("\nNotas cadrastadas:");

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            double maiorNota = notas[0];
           double Menornota = notas[0];
            double soma = 0;

            foreach (double nota in notas)
            {
                if (nota > maiorNota)
                {
                    maiorNota = nota;
                }
                if (nota < Menornota)
                {
                    Menornota = nota;
                }   
                   soma += nota;
              
            }
            double media = soma / notas.Count;
            Console.WriteLine($"\n maior nota é {maiorNota}:");
            Console.WriteLine($"\n menor nota é {Menornota}:");
            Console.WriteLine($"\n a medias das nota é {media}:");

        }
    }
}
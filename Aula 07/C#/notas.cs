using System;

class escola
{
    static void Main()
    {
        int[] notas = new int[10];
        string[] nomes = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Nome do aluno: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Nota: ");
            notas[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nClassificação dos alunos:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{nomes[i]} - Nota: {notas[i]} - Classificação: {ClassificarAluno(notas[i])}");
        }
    }

    static string ClassificarAluno(int nota)
    {
        if (nota < 60)
        {
            return "Aluno reprovado";
        }
        else if (nota <= 70)
        {
            return "Aluno em recuperação";
        }
        else
        {
            return "Aluno aprovado";
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {   
       Console.WriteLine("digite o numero de funcionarios: ");
       int funcionarios = int.Parse(Console.ReadLine());
       
        for (int i = 1; i <= funcionarios; i++)
        {
            Console.WriteLine($"\nfuncionario {i}:");

            Console.WriteLine("horas trabalhadas:");
            int total_de_horas_trabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("valor por hora:");
            double valor_hora = double.Parse(Console.ReadLine());

            double salario = total_de_horas_trabalhadas * valor_hora;
            Console.WriteLine("SALARIO = R$ " + salario.ToString("F2"));
            
        }
        


    }
}
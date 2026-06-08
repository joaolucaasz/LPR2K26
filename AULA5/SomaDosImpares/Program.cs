using System;

class Program
{
    static void Main()
    {
        int soma = 0;

        for (int numero = 50; numero <= 500; numero++)
        {
            if(numero % 3 == 0 && numero % 2 !=0)
            {
               soma += numero; 
            }
        }
            Console.WriteLine("A soma dos número é: "+ soma);

    }
}
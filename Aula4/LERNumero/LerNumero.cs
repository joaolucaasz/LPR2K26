using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine("digite seu numero: ");
        int numero = int.Parse(Console.ReadLine());
        
        if( numero % 2 == 0)
        {
            Console.WriteLine("o numero é par");
        }
        else
        {
            Console.WriteLine("o numero é impar");
        }




    }





}
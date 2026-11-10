using System;

namespace usuario
{
    class Usuario
    {
        static void Main()
        {

        int [] numeros = new int [10];
        int [] numerousuario = new int[10];
 
       
        for (int i= 0; i <numeros.Length; i++)
            {
                Console.WriteLine("digite um numero");
                numeros[i] = int.Parse(Console.ReadLine());
                 Array.IndexOf(numeros,10);

            }


        }

    }
}
using System;

class exemplovetor
{
    static void Main()
    {
      int [] numeros  = new int [10];
      int [] numerospar = new int[10];
      int [] numerosimpar = new int[10];
      int[] numero = { 5,8,7,9,6,4,10,8,10,9}; 

      for (int i = 0; i <numeros.Length; i++)
        {
             numeros[i] = int.Parse(Console.ReadLine());

             if (numeros[i] % 2 == 0)
    {
                 pares[qtdPares] = numeros[i];
                qtdPares++;
    }
            else
    {
                impares[qtdImpares] = numeros[i];
                qtdImpares++;
    }
            Console.WriteLine("numeros pares:");
            
             for (int i = 0; i < qtdPares; i++)
    {
             Console.WriteLine(pares[i]+ "  ");
    }
        Console.WriteLine("numeros impares:");
        for(int i = 0; i < qtdImpares; i++)
        {
            Console.WriteLine(impares[i]+ "  ");
        }
    }
}
}

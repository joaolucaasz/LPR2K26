using System;

class Program
{
    static void Main()
    {
        Random numAleatorio = new Random();
        int valorinteiro = numAleatorio.Next(1,100);
        int chute;
        int tentativas = 0;

        do
        {
            Console.WriteLine("digite um numero: ");
            chute = int.Parse(Console.ReadLine());
            tentativas ++;

            if (chute > valorinteiro)
            {
                Console.WriteLine("seu numero é menor, chutou ALTO");
            }
            else if (chute < valorinteiro)
            {
                Console.WriteLine("seu numero é maior, chutou BAIXO");
            }
                else
            {
                Console.WriteLine("acertou!!");
            }
            
        }while(chute != valorinteiro);
            Console.WriteLine("Tentativas: " + tentativas);
    }
}
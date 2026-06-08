using System.Runtime.CompilerServices;

sing System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("escolha a sua classe: ");
        Console.WriteLine("1 - Guerreiro");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueiro");

        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Console.WriteLine(" Ataque pesado, defesa total");
                break;

            case "2":
                Console.WriteLine("Bola de fogo, escudo de gelo");
                break;
            case "3":
                Console.WriteLine("flecha Precisa, disparo triplo");
                break;
                default:
                    Console.WriteLine("escolha uma opção valida:");
                    break;

        }

    }


}
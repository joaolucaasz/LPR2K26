using System;
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("digite o nome do heroi:");
       string nome = Console.ReadLine();
         Console.WriteLine("digite a pontuaçao do heroi:");
         int pontuacao = int.Parse(Console.ReadLine());
         Console.WriteLine("digite o poder do heroi:");
         string poder = Console.ReadLine();
         Console.WriteLine($"Herói cadastrado: {nome}, pontuação: {pontuacao}, poder: {poder}");
      
      
}
static void cadastrarHeroi()
    {
        Console.WriteLine("herois disponiveis:");
        
    }
}
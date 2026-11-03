using System.Security.Cryptography.X509Certificates;

namespace aula_11
{
    internal class retangulo
    {
        //Fazer um programa para ler os valores da largura e altura de um retângulo.Em seguida, mostrar na tela o valor de sua
        //área e perímetro.Usar a seguinte classe:
        //Retangulo
        // double Altura double LarguracalcArea()  calcPerimetro()

        public double largura;
        public double altura;

        public double calcArea()
        {
            return  altura * largura;

        }
        public double calcperimetro()
        {
            return 2 * (altura + largura);
        }
        static void Main(string[] args)
        {
            retangulo retangulo = new retangulo();

            Console.WriteLine("digite a largura do retangulo");
            retangulo.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a altura do retangulo");
            retangulo.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + retangulo.calcArea());
            Console.WriteLine("Perimetro: " + retangulo.calcperimetro());


        }
    }
}

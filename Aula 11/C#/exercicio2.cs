using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace aula_11
{
    internal class funcionario
    {
            // Fazer um programa para ler osdados de um funcionário(nome, saláriobruto e imposto).
             //A classe funcionário deve conter os
            //seguintes métodos:
            //  ○ Mostrar os dados do funcionário(nome e salário líquido). ○ Aumentar o salário do funcionário com base em uma porcentagem dada
            //OBS: Tabela de Imposto
            //○ 10% para salários de até 2000
            // ○ 15% para salários de até 3000
            // ○ 20% para salários superiores a 3000

        public string nome;
        public double imposto;
        public double salario_bruto;
        public double salario_liquido;

        public double calcsalario()
        {
            if (salario_bruto <= 2000)
            {
                imposto = 0.10;
            }
            else if (salario_bruto <= 3000)
            {
                imposto = 0.15;
            }

            else
            {
                imposto = 0.20;
            }
            salario_liquido = salario_bruto * (1 - imposto);
            
            return salario_liquido;
        }
        public void mostrardados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salário líquido: " + calcsalario().ToString("F2"));
        }
        public void aumentarsalario(double porcentagem)
        {
            salario_bruto = salario_bruto * (1 + porcentagem / 100.0);
        }
        static void Main(string[] args)
        {
            funcionario funcionario = new funcionario();

            Console.WriteLine("nome:");
            funcionario.nome = Console.ReadLine();

            Console.WriteLine("Salario bruto: ");
            funcionario.salario_bruto = double.Parse(Console.ReadLine());

            funcionario.mostrardados();

            Console.Write("porcentagem de aumento");
            double porcentagem = double.Parse(Console.ReadLine());

            funcionario = aumentarsalario(porcentagem);

            Console.WriteLine("dps do aumento: ");
            funcionario.mostrardados();

        }
    }
}

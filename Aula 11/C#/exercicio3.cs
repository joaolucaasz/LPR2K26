
namespace aula_11
{
    internal class Aluno
    {
        public int matricula;
        public string nome;
        public double nota1;
        public double nota2;
        public double trabalho;

        public double media()
        {
            return (nota1 * 2.5 + nota2 * 2.5 + trabalho * 2) / 7;
        }

        public double final()
        {
            if (media() >= 60)
            {
                return 0;
            }
            else
            {
                return 120 - media();
            }
        }

        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite a matricula do aluno:");
            aluno.matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do aluno:");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");
            aluno.nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            aluno.nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do trabalho:");
            aluno.trabalho = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + aluno.nome);
            Console.WriteLine("Matricula: " + aluno.matricula);
            Console.WriteLine("Media: " + aluno.media());
            Console.WriteLine("Nota necessaria na final: " + aluno.final());
        }
    }
}

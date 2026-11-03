
using System;
using System.Collections.Generic;

namespace aula_11
{
    internal class Cliente
    {
        public string nome;
        public int codigo;
        public List<Reserva> reservas = new List<Reserva>();

        public void adicionarReserva(Reserva reserva)
        {
            reservas.Add(reserva);
            reserva.cliente = this;
        }

        public void listarReservas()
        {
            Console.WriteLine("Reservas do cliente: " + nome);

            foreach (Reserva reserva in reservas)
            {
                Console.WriteLine("Numero da reserva: " + reserva.numero);
                Console.WriteLine("Data: " + reserva.data);
            }
        }
    }

    internal class Reserva
    {
        public int numero;
        public string data;
        public Cliente cliente;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Digite o nome do cliente:");
            cliente.nome = Console.ReadLine();

            Console.WriteLine("Digite o codigo do cliente:");
            cliente.codigo = int.Parse(Console.ReadLine());

            Reserva reserva1 = new Reserva();

            Console.WriteLine("Digite o numero da primeira reserva:");
            reserva1.numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data da primeira reserva:");
            reserva1.data = Console.ReadLine();

            cliente.adicionarReserva(reserva1);

            Reserva reserva2 = new Reserva();

            Console.WriteLine("Digite o numero da segunda reserva:");
            reserva2.numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data da segunda reserva:");
            reserva2.data = Console.ReadLine();

            cliente.adicionarReserva(reserva2);

            cliente.listarReservas();
        }
    }
}

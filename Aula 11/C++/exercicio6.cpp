
#include <iostream>
#include <vector>
#include <string>

using namespace std;


class Cliente;

class Reserva {
private:
    int codigo;
    string data;
    Cliente* cliente; 

public:
    Reserva(int cod, string dt) {
        codigo = cod;
        data = dt;
        cliente = nullptr;
    }

    void setCliente(Cliente* c) {
        cliente = c;
    }

    void mostrarReserva() {
        cout << "Codigo: " << codigo << endl;
        cout << "Data: " << data << endl;
    }
};


class Cliente {
private:
    string nome;
    vector<Reserva*> reservas;

public:
    Cliente(string n) {
        nome = n;
    }

  
    void adicionarReserva(Reserva* r) {
        reservas.push_back(r);
        r->setCliente(this);
    }

  
    void listarReservas() {
        cout << "\nReservas de " << nome << ":\n";

        if (reservas.empty()) {
            cout << "Nenhuma reserva encontrada.\n";
            return;
        }

        for (Reserva* r : reservas) {
            r->mostrarReserva();
            cout << "----------------\n";
        }
    }
};


int main() {
    Cliente cliente1("Joao");

    Reserva reserva1(101, "10/11/2026");
    Reserva reserva2(102, "15/11/2026");
    Reserva reserva3(103, "20/11/2026");

    cliente1.adicionarReserva(&reserva1);
    cliente1.adicionarReserva(&reserva2);
    cliente1.adicionarReserva(&reserva3);

    cliente1.listarReservas();

    return 0;
}

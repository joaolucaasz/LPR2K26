#include <iostream>
#include <string>
using namespace std;

void carteira (int idade, bool temCarteira){

    //int idade = 20;
    //bool temCarteira = false;
    if((idade >= 18 && temCarteira) || (idade > 60)){
        cout << "Pode dirigir" << endl;
    } else {
        cout << "Nao pode dirigir" << endl;
    }
  
}
      void segundou(int numero, string dia) {

    if (numero > 0) {
        cout << "positivo" << endl; 
        if (dia == "segunda") {
            cout << "Hoje é segunda" << endl;
        } else {
            cout << "outro caso" << endl;
        }  
           
        }

    }            
       void osdeverdade (int x){
         // int x = 10; 
          if ( x> 20 && x<5){
            cout << " condiçao verdadeira" << endl;
          } else {
            cout <<" condiçao falsa" << endl;
          }
        }
        
        int main() {
            int opcao;
            do {
            cout << "escolha uma opcao: " << endl;
            cout <<"1- verificar idade" << endl;
            cout << "2- verificar numero e dia" << endl;
            cout << "3- verificar condicao" << endl;
            cout << "escolha alguma opcao:";
            cin >> opcao;

            if (opcao ==1) {          
            int idade;
            bool temCarteira;
            cout << "Digite sua idade: ";
            cin >> idade;
            cout << "Tem carteira de motorista? (1 para sim, 0 para nao): ";
            cin >> temCarteira;

            carteira(idade, temCarteira);
            }
            else if (opcao == 2){
                int numero;
            string dia;
            cout << "Digite um numero inteiro: ";
            cin >> numero;
            cout << "Digite o dia da semana: ";
            cin >> dia;
            segundou(numero, dia);          
        }
             else if (opcao == 3){ 
            int x;
            cout << "Digite um numero inteiro: ";
            cin >> x;

            osdeverdade(x); }         
            
        } while (opcao != 0);
    return 0;
    }


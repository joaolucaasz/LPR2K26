#include <iostream>
using namespace std;

int main()
{
    int numero;
    
    cout << "Digite um numero: ";
    cin >> numero;

    int quadrado = numero * numero;
    int soma = 0;

        while (quadrado > 0)
    {
        int digito = quadrado % 10;
        soma += digito;
        quadrado /= 10;
    }
      cout << "soma (while): " << soma << endl;
        return 0;
     
  }
#include <iostream>
using namespace std;

int main() {
    int nmr;
    cout << "Digite um numero inteiro: ";
    cin >> nmr;

    int invertido = 0;
    while (nmr >0){
        int digito = nmr % 10;
        invertido = invertido * 10 + digito;
        nmr /= 10;
    }
    cout << "O numero invertido e: " << invertido << endl;
    return 0;
}

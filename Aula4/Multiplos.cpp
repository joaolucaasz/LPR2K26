#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    int A, B;
    
        cout << "Digite o valor do A: "; cin >> A;
        cout << "Digite o valor do B: "; cin >> B;

        if ((A % B == 0) || (B % A == 0) ){

            cout <<"sao Multiplos: " << A << endl;
        }
        else{
            cout <<"nao sao multiplos:" << A << " e " << B << endl;
        }
            
            
        
        }
        




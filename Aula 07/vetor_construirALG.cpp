#include <iostream>
using namespace std;

int main()
{
    int vetor[10];
    int numero;
    int ocorrencias = 0;


    for(int i = 0; i < 10; i++)
    {
        cout << "Digite o " << i + 1 << " numero: ";
        cin >> vetor[i];
    }

    cout << "\nDigite o numero que deseja pesquisar: ";
    cin >> numero;
  
    cout << "\nPosicoes encontradas: ";

    for(int i = 0; i < 10; i++)
    {
        if(vetor[i] == numero)
        {
            cout << i << " ";
            ocorrencias++;
        }
    }

    
    if(ocorrencias > 0)
    {
        cout << "\nquantidade de ocorrencias: " << ocorrencias;
    }
    else
    {
        cout << "\nnumero nao encontrado no vetor.";
    }

    return 0;
}
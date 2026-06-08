#include <iostream>
#include <iomanip>//biblioteca p casa decimais

using namespace std;
int main()
{
    int diferenca;
    int A, B, C, D;
    cin >> A >> B >> C >> D;
    diferenca = (A*B) - (C*D);
    cout<<fixed<<setprecision(4)<<"diferenca = "<<diferenca<<endl;

    return 0;
}
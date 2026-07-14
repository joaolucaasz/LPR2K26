#include <iostream>
#include <vector>
#include <map>
#include <string>

using namespace std;

int main() {
    int n;
    cin >> n;

 
    map<int, vector<string>> nomes;

    string s;
    for (int i = 0; i < n; i++) {
        cin >> s;
        nomes[s.size()].push_back(s);
    }

   
    int maxlinhas = 0;
    for (auto &p : nomes)
        if ((int)p.second.size() > maxlinhas)
            maxlinhas = p.second.size();


    for (int i = 0; i < maxlinhas; i++) {
        bool primeiro = true;

        for (auto &p : nomes) {
            if (i < (int)p.second.size()) {
                if (!primeiro)
                    cout << " ";
                cout << p.second[i];
                primeiro = false;
            }
        }
        cout << endl;
    }

    return 0;
}
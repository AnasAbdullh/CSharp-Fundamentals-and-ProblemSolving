#include <iostream>
#include <algorithm>
#include <numeric>

using namespace std;

int main() {

    int Y;
    int W;

    cin >> Y >> W;

    int Max = max(Y,W);

    int WinningCases = 1 + 6 - Max;

    int GCD = gcd(WinningCases,6);

    cout << WinningCases / GCD << "/" << 6 / GCD << endl;

}

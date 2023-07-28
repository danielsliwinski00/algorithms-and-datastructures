#include <iostream>
using namespace std;

void DNAreplacement(string S, string Y, string L, string R, string X)
{
    // X replaces Y within string S when L is before it but R is not after it.

    int n = S.length();     //getting the length of all strings in case needed
    int a = Y.length();
    int b = L.length();
    int c = R.length();
    int d = X.length();

    for (int i = 0; i <= (n - a); i++)
    {
        int j = 0; 
        
        while (j < a && S[i + j] == Y[j]) //loop to find out i using j
        {
            j++;
        }
        
        if (j == a) //when j==a i shows us the location where in S theres a match for Y 
        {
            
            if (i - (b) >= 0 && i + a <= n) //if theres info before i and after i,
            {                              //carry on (theres conditions for what precedes and follows i)
                if ( (S.substr((i - (b)), b)).compare(L) == 0)  //if what precedes i matches L carry on
                {
                    if ((S.substr((i + a), c)).compare(R) == 0) //if what follows i matches R returns nothing
                    {
                    }
                    else // if what follows i does not match R output the string with the replaced letters
                    {
                        string x = S;
                        x.replace(i, a, X);
                        cout << x << " ";
                    }
                }
            }           
        }
    }
}

int main()
{
    /*
    string S = "ATATATATGTATATATGTA";
    string Y = "TAT";
    string L = "A";
    string R = "GT";
    string X = "GG";
    */
    
    string S;

    string Y;
    string L;
    string R;
    string X;

    cout << "Input the dna string: ";
    cin >> S;
    cout << "Input the substring to be replaced: ";
    cin >> Y;
    cout << "Input the substring which precedes the substring to be replaced: ";
    cin >> L;
    cout << "Input the substring which should not follow the substring to be replaced: ";
    cin >> R;
    cout << "Input the substring to replace the substring specified previously: ";
    cin >> X;

    //input window code if needed

    DNAreplacement(S, Y, L, R, X);  //running the replacement code
}


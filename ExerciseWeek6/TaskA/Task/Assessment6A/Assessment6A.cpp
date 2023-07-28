// Assessment6A.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include<string>

using namespace std;

void Replace(char* S, char x1, char x2)
{
    char special = '!'; //special character is !

    while (*(S + 1) != '\0')    //loop
    {
        if (*(S - 1) == special && *S == x1)
        {
            *S = x2;
        }
        S++;
    }
}

int main()
{
    string strings; //setting variables
    char origin;
    char replace;

    cout << "Enter the string to be changed: " << endl;
    cin >> strings;
    cout << "Enter the character you want to change: " << endl;
    cin >> origin;
    cout << "Enter the character you want to replace the previously selected character: " << endl;
    cin >> replace;

    Replace(&strings[0], origin, replace); //replace the characters with the inputted values
    cout << strings; //output the changed string
}
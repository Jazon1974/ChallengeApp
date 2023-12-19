using System.ComponentModel.Design;
using System.Globalization;

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
Console.WriteLine("Wyniki dla liczby: " + number);

for (var digit = 0; digit < 10; digit++)
{
    var i = 0;
    foreach (char c in letters)
    {
        string numInString = digit.ToString();
        char[] lettersDigit = numInString.ToArray();
        var d = lettersDigit[0];
        if (d == c)
        {
            i++;
        }
    }
    Console.WriteLine(digit + "=> " + i);
}


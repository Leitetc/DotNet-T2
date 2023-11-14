// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

#region Divisiveis

 Console.WriteLine("Números divisíveis por 3 ou 4 entre 0 e 30:");

        for (int Resto = 0; Resto <= 30; Resto++)
        {
            if (Resto % 3 == 0 || Resto % 4 == 0)
            {
                Console.WriteLine(Resto);
            }
        }

#endregion

﻿
/* #region Foreach examples

string[] people = { "Maria", "João", "José", "Ana" };

foreach(string person in people)
{
    Console.WriteLine(person);
}
#endregion
 */

#region Fibonacci
int fib1 = 0;
int fib2 = 1;
int fib3;

Console.WriteLine(fib1);
Console.WriteLine(fib2);

fib3 = fib2+fib1;

while (fib3 <= 100)
{
    Console.WriteLine(fib3);
    fib1 = fib2;
    fib2 = fib3;
    fib3 = fib2 + fib1;
}
 #endregion
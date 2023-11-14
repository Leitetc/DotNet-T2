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

#region Fibonacci
#endregion
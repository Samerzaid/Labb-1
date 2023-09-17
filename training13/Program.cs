

using System.Collections.Generic;

Console.ForegroundColor = ConsoleColor.DarkMagenta;

// Nata in en string kallas input: "29535123p48723487597645723645"
Console.Write("Input: ");
string input = Console.ReadLine();
Console.ResetColor();
string markerad = "";
int count = 0;  // count = Antal rader
long sum = 0;  // sum = Total 

/*Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
siffror förekommer där emellan.*/

for (int x = 0; x < input.Length; x++)
{


    markerad = "";

    if (Char.IsDigit(input[x]))
    {
        markerad += input[x];
        for (int y = x + 1; y < input.Length; y++)
        {
            if (Char.IsDigit(input[y]))
            {
                markerad += input[y];
                if (input[x] == input[y])
                {
                    count++;
                    sum += Convert.ToInt64(markerad);
                    Console.ResetColor();
                    Console.Write(input.Substring(0, x));
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(markerad);
                    Console.ResetColor();
                    Console.WriteLine(input.Substring(y + 1, (input.Length - (y + 1))));

                    markerad = "";
                    y = input.Length;
                }

            }
            else
            {
                markerad = "";
                y = input.Length;


            }


        }

    }
    else
    {

        continue;

    }

}
Console.ReadKey();
Console.WriteLine("__________________________");

/*Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut det
sist i programmet. Gör gärna en tom rad emellan för att skilja från output ovan.*/
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Tal : " + count);
Console.ReadKey();
Console.WriteLine("__________________________");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Total : " + sum);
Console.ResetColor();



using System;

// Write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

class PrintTheASCIITable
{
    static void Main()
    {
        char symbol;
        for (int i = 0; i <= 255; i++)
        {
            symbol = (char)i;
            Console.WriteLine("{0} -> {1}", i, symbol);
        }
    }
}

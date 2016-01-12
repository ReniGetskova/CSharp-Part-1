using System;

// Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

class IsoscelesTriangle
{
    static void Main()
    {
        char symbol = '\u00a9';
        int symbolCount = 4;
        for (int i = 0; i < symbolCount; i++)
        {
            for (int j = symbolCount - i - 1; j > 0; j--)
            {
                Console.Write(" ");
                
            }
            for (int k = 0; k <= i; k++)
            {
                Console.Write(symbol + " ");
                
            }
            Console.WriteLine();
        }

    }
        
}


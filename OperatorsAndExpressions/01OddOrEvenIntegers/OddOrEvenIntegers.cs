using System;

// Write an expression that checks if given integer is odd or even.

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Insert a number");
        string takeNumber = Console.ReadLine();
        int number = int.Parse(takeNumber);
        if (number % 2 == 0)
        {
            Console.WriteLine("The number {0} is even", number);
        }
        else
        {
            Console.WriteLine("The number {0} is odd", number);
        }
    }
}


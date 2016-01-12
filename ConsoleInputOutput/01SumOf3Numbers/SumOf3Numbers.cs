using System;

// Write a program that reads 3 real numbers from the console and prints their sum.
class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Input value a = ");
        string takeA = Console.ReadLine();
        double a = double.Parse(takeA);

        Console.Write("Input value b = ");
        string takeB = Console.ReadLine();
        double b = double.Parse(takeB);

        Console.Write("Input value c = ");
        string takeC = Console.ReadLine();
        double c = double.Parse(takeC);

        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);

    }
}

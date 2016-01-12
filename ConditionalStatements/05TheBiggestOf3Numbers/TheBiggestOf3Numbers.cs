using System;

// Write a program that finds the biggest of three numbers.
class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Program that find the biggest of three numbers");
        Console.Write("Insert a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Insert b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Insert c = ");
        double c = double.Parse(Console.ReadLine());
        bool biggestA = a > b && a > c;
        bool biggestB = b > a && b > c;
        bool biggestC = c > a && c > b;
        if (biggestA)
        {
            Console.WriteLine(a); 
        }
        if (biggestB)
        {
            Console.WriteLine(b);
        }
        if (biggestC)
        {
            Console.WriteLine(c);
        }
    }
}

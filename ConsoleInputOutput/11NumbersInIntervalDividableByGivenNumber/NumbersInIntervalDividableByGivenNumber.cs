using System;

// Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
// such that the reminder of the division by 5 is 0.
class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        string takeA, takeB;
        int a = 0, b = 0;
        do
        {
            Console.WriteLine("Insert two positive integer numbers and program will print you all numbers is that interval that divided by 5");
            Console.Write("a = ");
            takeA = Console.ReadLine();
            a = int.Parse(takeA);
            Console.Write("b = ");
            takeB = Console.ReadLine();
            b = int.Parse(takeB);
        } while (a > b);
        int count = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0} ", i);
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Count of numbers that divided by 5 in interval [{0}, {1}] is: {2}", a, b, count);
        
    }
}

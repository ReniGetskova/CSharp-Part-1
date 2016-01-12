using System;

// Write a program that finds the biggest of five numbers by using only five if statements
class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Program that finds the biggest of five numbers");
        double[] array = new double[5];
        double maxElement = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
            if (maxElement < array[i])
            {
                maxElement = array[i];
            }
        }
        Console.WriteLine("\nMax element: {0}", maxElement);
    }
}

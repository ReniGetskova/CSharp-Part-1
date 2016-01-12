using System;
using System.Linq;
using System.Text;

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

class RandomizeNnumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Random randomNumber = new Random();
        int[] numbers = Enumerable.Range(1, n).OrderBy(r => randomNumber.Next()).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }

        Console.WriteLine();
    }
}


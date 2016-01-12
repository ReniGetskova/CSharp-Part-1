using System;

//Write a program that enters 3 integers n, min and max(min != max) and prints n random numbers in the range[min...max].

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter min interval number:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter max interval number:");
        int max = int.Parse(Console.ReadLine());

        if (min >= max)
        {
            Console.WriteLine("Invalid interval");
            return;
        }

        //new Random() must to be outside of the loop
        Random randomNumber = new Random();
        string result = "";
        for (int i = 0; i < n; i++)
        {
            result += randomNumber.Next(min, max + 1) + " ";
        }

        Console.WriteLine(result);
    }
}


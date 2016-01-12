using System;

// Write a program that reads an integer number n from the console and prints all the numbers in the 
// interval [1..n], each on a single line.
class NumbersFrom1Ton
{
    static void Main()
    {
        Console.Write("Input an integer number and the program will print all numbers from 1 to n\nn = ");
        string takeNumber = Console.ReadLine();
        int number = int.Parse(takeNumber);
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

using System;

// Write a program that enters 5 numbers (given in a single line, separated by a space), 
// calculates and prints their sum
class Program
{
    static void Main()
    {
        Console.WriteLine("Insert five numbers in a single line, separated by a space");
        string takeNumbers = Console.ReadLine();
        string[] strArr = takeNumbers.Split(' ');
        double[] numArr = new double[strArr.Length];
        double sum = 0;
        for (int i = 0; i < strArr.Length; i++)
        {
            numArr[i] = double.Parse(strArr[i]);
            sum += numArr[i];
        }
        Console.WriteLine("Sum of array's elements is: {0}", sum);

    }
}

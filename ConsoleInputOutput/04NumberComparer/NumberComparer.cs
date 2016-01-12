using System;

// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.

class NumberComparer
{
    static void Main()
    {
        Console.Write("Input first number a = ");
        string takeFirst = Console.ReadLine();
        double firstNum = double.Parse(takeFirst);

        Console.Write("Input second number b = ");
        string takeSecond = Console.ReadLine();
        double secondNum = double.Parse(takeSecond);
        Console.Write("Grater number is: ");
        Console.WriteLine(firstNum > secondNum ? firstNum : secondNum);
    }
}

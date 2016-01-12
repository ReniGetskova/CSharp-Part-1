using System;
// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
// (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 
class FibonacciNumbers
{
     // using recursive algorithm to find numbers
     // first numbers are 0 and 1
     // next number is sum of previous two numbers
     // 5 = 3 + 2
     // 8 = 5 + 3
     //etc........
    
    static int fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        return
            fibonacci(n - 1) + fibonacci(n - 2);
    }
    static void Main()
    {
        Console.Write("How many Fibonacci numbers do you want to print on the console? \nn = ");
        string takeN = Console.ReadLine();
        int n = int.Parse(takeN);
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}, ", fibonacci(i));
        }
        Console.WriteLine();

    }
}

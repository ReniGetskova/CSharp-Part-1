using System;
using System.Numerics;

//Write a program that calculates n! / k! for given n and k(1 < k<n< 100).
//Use only one loop.

class DevideFactorials
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger result = Factorial(n) / Factorial(k);
        Console.WriteLine("{0}!/{1}! = {2}", n, k, result);
    }

    private static BigInteger Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}


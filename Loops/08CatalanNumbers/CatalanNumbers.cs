using System;
using System.Numerics;

//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
//Example:
//n  | Catalan(n)
//0  | 1
//5	 | 42
//10 | 16796
//15 | 9694845

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        //using formula: (2n)! / (n + 1)!n!
        BigInteger result = (Factorial(2 * n)) / ((Factorial(n + 1) * Factorial(n)));

        Console.WriteLine(result);
    }
    private static BigInteger Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}



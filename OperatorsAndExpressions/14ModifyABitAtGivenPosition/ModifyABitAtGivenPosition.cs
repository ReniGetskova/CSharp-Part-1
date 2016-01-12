using System;

// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position 
// p from the binary representation of n while preserving all other bits in n.

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Program that modifies bit on a given position");
        Console.Write("Insert number n = ");
        string takeN = Console.ReadLine();
        int n = int.Parse(takeN);
        Console.Write("Insert position p = ");
        string takeP = Console.ReadLine();
        int p = int.Parse(takeP);
        Console.Write("Insert bit 0 or 1: bit = ");
        string takeBit = Console.ReadLine();
        int bit = int.Parse(takeBit);
        int result;
        if (bit == 1) 
        {
            // Set the p-th bit
            result = n | (1 << p);
        }
        else 
        {
            // Unset the n-th bit
            result = n & ~(1 << p);
        }
        takeN = Convert.ToString(n, 2);
        Console.WriteLine("Binary representation of n: {0}", takeN.PadLeft(16, '0'));
        string binaryResult = Convert.ToString(result, 2);
        Console.WriteLine("Binary result: {0,29}", binaryResult.PadLeft(16, '0'));
        Console.WriteLine("Result: {0}", result);
    }
}

using System;

// Write an expression that extracts from given integer n the value of given bit at index p
class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Program that extracts given bit on position p from integer number n");
        Console.Write("Insert integer number: n = ");
        string takeN = Console.ReadLine();
        int n = int.Parse(takeN);
        takeN = Convert.ToString(n, 2);
        int p;
        do
        {
            Console.Write("Insert position: p = ");
            p = int.Parse(Console.ReadLine());
        } while (p > n);
        //put bit 1 on position p
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine(takeN.PadLeft(16, '0'));
        Console.WriteLine(bit);
        
    }
}

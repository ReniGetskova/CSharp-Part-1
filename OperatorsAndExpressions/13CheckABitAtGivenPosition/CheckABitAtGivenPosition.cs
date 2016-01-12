using System;

// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
// in given integer number n, has value of 1.
class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Program that return True if bit on given position is 1 and False if that bit is 0");
        Console.Write("Insert integer number: n = ");
        string takeN = Console.ReadLine();
        int n = int.Parse(takeN);
        int p;
        bool isOne;
        do
        {
            Console.Write("Insert position: p = ");
            p = int.Parse(Console.ReadLine());
        } while (p > n && n != 0);

        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;

        takeN = Convert.ToString(n, 2);
        Console.WriteLine(takeN.PadLeft(16, '0'));
        isOne = 1 == bit;
        Console.WriteLine(isOne);
       
     
    }
}

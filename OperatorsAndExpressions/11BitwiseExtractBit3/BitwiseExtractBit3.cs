using System;

// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("Insert positive integet number: n = ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        input = Convert.ToString(number, 2);
        Console.WriteLine(input.PadLeft(16, '0'));
        int position = 3;
        //make mask that has bit 1 on 3th position
        int mask = 1 << position;
        //remove all 1 bits from number 
        int numberAndMask = number & mask;
        //shit on left bit that is on 3th position and save this value in variable 
        int bit = numberAndMask >> position;
        //print what we have on that position
        Console.WriteLine(bit);
        
    }
}

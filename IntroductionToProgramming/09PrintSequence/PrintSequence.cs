using System;

// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
class PrintSequence
{
    static void Main()
    {
        /*
         2 - 5 = -3
         4 - 9 = -5
         6 - 13 = -7
         ...........
         etc.
        */
        int difference = -5;
        int incrementDifference = -4;
        for (int i = 2; i <= 10; i += 2)
        {
            Console.WriteLine(i);
            int temp = i;
            i += difference;
            Console.WriteLine(i);
            difference = difference + incrementDifference;
            i = temp;
        }
    }
}
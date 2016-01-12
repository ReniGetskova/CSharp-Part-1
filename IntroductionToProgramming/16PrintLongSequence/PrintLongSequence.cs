using System;

class PrintLongSequence
{
    static void Main()
    {
        // first numbers of sequence
        int even = 2;
        int odd = -3;
        // if we want to display numbers on separate line with ConsoleWriteLine() we have to increase 
        // the console buffer size to see all numbers
        Console.BufferHeight = 5000;
        // print first numbers
        Console.Write("{0,5}", even);
        Console.Write("{0,5}", odd);
        // count numbers which I print on console
        int count = 2;
        for (int i = 0; i <= 498; i++)
        {
            even = even + 2;
            Console.Write("{0,5}", even);
            // print even number and increase counter
            count++;
            odd = odd - 2;
            Console.Write("{0,5}", odd);
            // print odd number and increase couter
            count++;
        }
        Console.WriteLine();
        Console.WriteLine("Count of numbers is {0}:", count);

    }
}

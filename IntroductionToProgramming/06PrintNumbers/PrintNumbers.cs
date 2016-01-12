using System;

//Write a program to print the numbers 1, 101 and 1001, each at a separate line.
class PrintNumbers
{
    static void Main()
    {
        /*
           1 = 1
           101 = 5
           1001 = 9
        */
        for (int i = 1; i < 10; i += 4)
        {
            string binary = Convert.ToString(i, 2);
            Console.WriteLine(binary);
        }


    }
}

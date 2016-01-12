using System;
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
//by 7 and 5 at the same time.

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Insert number");
        string takeNumber = Console.ReadLine();
        int number = int.Parse(takeNumber);
        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("Number {0} can be divided by 7 and 5 at the same time", number);
        }
        else
        {
            Console.WriteLine("Number {0} can NOT be divided by 7 and 5 at the same time", number);
        }

    }
}

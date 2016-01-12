using System;

// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
// Prints on the console the number in reversed order: dcba (in our example 1102).
// Puts the last digit in the first position: dabc (in our example 1201).
// Exchanges the second and the third digits: acbd (in our example 2101).

//The number has always exactly 4 digits and cannot start with 0.
class FourDigitNumber
{
    // use functions to complete separate tasks
    static int SumDigits(int number)
    {
        int digit = 0;
        int sum = 0;
        for (int i = 0; i < 4; i++)
        {
            digit = number % 10;
            number = number / 10;
            sum += digit;
        }
        return sum;
    }

    static void ReverseOrder(int number)
    {
        int digit = 0;
        for (int i = 0; i < 4; i++)
        {
            //start from last digit anyway and print on the console
            digit = number % 10;
            Console.Write(digit);
            number = number / 10;
        }
        Console.WriteLine();
    }

    static void LastFirst(int number)
    {
        int digit = 0;
        digit = number % 10;
        number = number / 10;
        // no need for cycle because we take only last digit and print it to the rest of the number
        Console.Write(digit);
        Console.Write(number);
        Console.WriteLine();
    }

    static void ExchangeSecondThird(int number)
    {
        int digit4 = number % 10;
        number = number / 10;
        int digit3 = number % 10;
        number = number / 10;
        int digit2 = number % 10;
        int digit1 = number / 10;
        Console.WriteLine("{0}{1}{2}{3}", digit1, digit3, digit2, digit4);
    }
   
    static void Main()
    {

        Console.WriteLine("Insert 4-digits number");
        string takeNumber = Console.ReadLine();
        int number = int.Parse(takeNumber);
        // make check if the number is 4-digits
        while(number < 1000 || number > 9999)
        {
            Console.WriteLine("Insert 4-digits number");
            takeNumber = Console.ReadLine();
            number = int.Parse(takeNumber);
        }
        Console.WriteLine("Sum of digits is: {0}", SumDigits(number));
        Console.Write("Number in reverse order is: ");
        ReverseOrder(number);
        Console.Write("Last digit in first position: ");
        LastFirst(number);
        Console.Write("Exchange second and third digits: ");
        ExchangeSecondThird(number);
    }
   
}

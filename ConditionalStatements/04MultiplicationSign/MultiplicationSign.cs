using System;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//    Use a sequence of if operators.

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Insert three numbers");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        // result is positive: (3 numbers are > 0) or (2 numbers are < 0 and 1 number is > 0)
        bool positiveResult = (a > 0 && b > 0 && c > 0) || ((a < 0 && b < 0 && c > 0) || (a < 0 && c < 0 && b > 0) || (b < 0 && c < 0 && a > 0));
        // result is negative: (3 numbers are < 0) or (1 number is < 0 and 2 numbers are > 0)
        bool negativeResult = (a < 0 && b < 0 && c < 0) || ((b > 0 && c > 0 && a < 0) || (a > 0 && b > 0 && c < 0) || (a > 0 && c > 0 && b < 0));
        // result is 0: one of the numbers is equal to 0
        bool zeroResult = (a == 0 || b == 0 || c == 0);
        char result;
        if (positiveResult)
        {
            result = '+';
            Console.WriteLine("{0,-5} {1,-5} {2,-5} {3,-5}", a, b, c, result);
        }
        if (negativeResult)
        {
            result = '-';
            Console.WriteLine("{0,-5} {1,-5} {2,-5} {3,-5}", a, b, c, result);
        }
        if (zeroResult)
        {
            result = '0';
            Console.WriteLine("{0,-5} {1,-5} {2,-5} {3,-5}", a, b, c, result);
        }
    }
}
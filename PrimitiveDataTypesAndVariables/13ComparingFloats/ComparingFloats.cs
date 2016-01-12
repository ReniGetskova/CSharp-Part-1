using System;
// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

class ComparingFloats
{
    static void Main()
    {
        // assign float number to double and for that we see the error
        double a = 10.7F;
        double b = 2.3F;
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        double expected = 13;
        bool isEqual = (a + b) == expected;
        Console.WriteLine((a + b) + " == " + expected + " --> " + isEqual);
        double acctual = a + b;
        double minDifference = 0.000001;
        isEqual = (acctual - expected) < minDifference;
        Console.WriteLine((expected - acctual) + " < " + minDifference + " --> " + isEqual +  " \nSo we can accept that acctual result is equal to expected");
    }
}


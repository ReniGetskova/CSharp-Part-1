using System;

// Create a console application that calculates and prints the square root of the number 12345

class SquareRoot
{
    static void Main()
    {
        int a = 12345;
        double result = Math.Sqrt(a);
        //print original result from method Sqrt
        Console.WriteLine(result);
        //print approximate result with 4 digits after comma
        Console.WriteLine("{0:0.0000}", result);
    }
}

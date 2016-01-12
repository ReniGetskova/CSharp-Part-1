using System;

// Write an if-statement that takes two double variables a and b and exchanges their values if the first one 
// is greater than the second one. As a result print the values a and b, separated by a space.
class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("The program will exchange values of a and b if a is grather than b");
        Console.Write("Insert value: a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Insert value: b = ");
        double b = double.Parse(Console.ReadLine());
        double temp;
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }
}

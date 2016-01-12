using System;

// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their 
// values by using some programming logic.
// Print the variable values before and after the exchange.


class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Value of a is: {0}", a);
        Console.WriteLine("Value of b is: {0}", b);
        // exchange values using temporaty variable
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After exchanging values of variables");
        Console.WriteLine("Value of a is: {0}", a);
        Console.WriteLine("Value of b is: {0}", b);
    }
}

using System;

// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

class NullValuesArithmetic
{
    static void Main()
    {
        int? ni = null;
        double? nd = null;
        Console.WriteLine("Value of null int variable is: " + ni);
        Console.WriteLine("Value of null doble variable is: " + nd);
        ni = 5;
        nd = 10;
        Console.WriteLine("After initialition value of null int variable is: " + ni);
        Console.WriteLine("After initialition value of null double variable is: " + nd);
        //ERROR because i is to null variable
        //int i = intVar;
        //Right way
        int i;
        if (ni.HasValue)
        {
            i = ni.Value;
            Console.WriteLine(@"Example:
Take value of null int variable and assign to regular int variable, 
value of which is: " + i);
        }

    }
}


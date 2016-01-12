using System;

// Write an expression that calculates trapezoid's area by given sides a and b and height h.

class Trapezoids
{
    // area = ((a + b) * h) / 2 
    static void Main()
    {
        double area = 0;
        Console.Write("Insert big base: a = ");
        string takeA = Console.ReadLine();
        double a = double.Parse(takeA);
        while (a <= 0)
        {
            Console.Write("Insert big base a = ");
            takeA = Console.ReadLine();
            a = double.Parse(takeA);
        }
        Console.Write("Insert small base: b =  ");
        string takeB = Console.ReadLine();
        double b = double.Parse(takeB);
        while (b <= 0)
        {
            Console.Write("Insert small base: b =  ");
            takeB = Console.ReadLine();
            b = double.Parse(takeB);
        }
        Console.Write("Insert height: h = ");
        string takeH = Console.ReadLine();
        double h = double.Parse(takeH);
        while (h <= 0)
	    {
	        Console.Write("Insert height: h = ");
            takeH = Console.ReadLine();
            h = double.Parse(takeH);  
	    }
        area = ((a + b) * h) / 2;
        Console.WriteLine("Area of trapezoid is: {0}", area);
    }
}

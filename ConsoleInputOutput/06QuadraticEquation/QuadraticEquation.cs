using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("This program finds real roots of quadratic equation: ax^2 + bx + c = 0");
        Console.Write("Insert value for coefficient a = ");
        string takeA = Console.ReadLine();
        double a = double.Parse(takeA);
        Console.Write("Insert value for coefficient b = ");
        string takeB = Console.ReadLine();
        double b = double.Parse(takeB);
        Console.Write("Insert value for coefficient c = ");
        string takeC = Console.ReadLine();
        double c = double.Parse(takeC);
        double determinant = b * b - 4 * a * c;
        if (determinant == 0)
        {
            Console.WriteLine("The quadratic equation has two equal roots x1 = x2 = {0}", -b / (2 * a));
        }
        if (determinant > 0)
        {   
            Console.WriteLine("The quadratic equation has two roots x1 = {0} and x2 = {1}", (-b - Math.Sqrt(determinant)) / (2 * a), (-b + Math.Sqrt(determinant)) / (2 * a));
        }
        if (determinant < 0)
        {
            Console.WriteLine("The quadratic equation has not real roots");
        }
    }
}

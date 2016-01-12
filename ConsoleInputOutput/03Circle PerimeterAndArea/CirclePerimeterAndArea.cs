using System;

// Write a program that reads the radius r of a circle and prints its perimeter and area 
// formatted with 2 digits after the decimal point.
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Input radius of a circle");
        string takeRadius = Console.ReadLine();
        double radius = double.Parse(takeRadius);
        double pi = 3.14159206;
        Console.WriteLine("Perimeter of a circle is: {0:F2}", 2 * pi * radius);
        Console.WriteLine("Area of a circle is: {0:F2}", pi * radius * radius);
    }
}

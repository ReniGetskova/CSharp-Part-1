using System;

// Write an expression that calculates rectangle’s perimeter and area by given width and height.
class Rectangles
{
    // Area S = a*b
    // Perimeter = 2*(a+b)
    static void Main()
    {
        Console.WriteLine("Insert height of the rectangle in centimeters");
        string takeHeight = Console.ReadLine();
        double height = double.Parse(takeHeight);
        while (height < 0)
        {
            Console.WriteLine("Insert height of the rectangle in centimeters");
            takeHeight = Console.ReadLine();
            height = double.Parse(takeHeight);
        }

        Console.WriteLine("Insert weight of the rectangle in centimeters");
        string takeWeight = Console.ReadLine();
        double weight = double.Parse(takeWeight);
        while (weight < 0)
        {
            Console.WriteLine("Insert weight of the rectangle in centimeters");
            takeWeight = Console.ReadLine();
            weight = double.Parse(takeWeight);
        }
        double area = height * weight;
        double perimeter = 2 * (height + weight);
        Console.WriteLine("Area of the rectangle is: {0} cm", area);
        Console.WriteLine("Perimeter of the rectangle is: {0} cm", perimeter);

    }
}

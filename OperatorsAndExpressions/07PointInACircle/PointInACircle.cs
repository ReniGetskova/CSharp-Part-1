using System;

// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
class PointInACircle
{
    // equation of circle with center (a,b) radius r and point (x,y)
    // (x - a)^2 + ( y - b)^2 = r^2
    // this formula is consequence from Pitagor'theorem
    static void Main()
    {
        double centerX = 0;
        double centerY = 0;
        double radius = 2;
        Console.WriteLine("Insert X coordinate of point:");
        string takeX = Console.ReadLine();
        double x = double.Parse(takeX);
        Console.WriteLine("Insert Y coordinate of point:");
        string takeY = Console.ReadLine();
        double y = double.Parse(takeY);
        bool isInside = false;
        if (Math.Sqrt((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY)) <= radius)
        {
            isInside = true;
            Console.WriteLine("Point with coordinates {0} and {1} is inside the circle", x, y);
        }
        Console.WriteLine(isInside);
        
    }
}

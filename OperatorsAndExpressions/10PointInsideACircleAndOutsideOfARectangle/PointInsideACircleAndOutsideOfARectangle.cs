using System;

// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2)
class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        double centerX = 1;
        double centerY = 1;
        double radius = 1.5;
        double width = 6;
        double heigth = 2;
        // left top corner (-1, 1)
        // left bottom corner (-1, -1)
        double left = -1;
        double top = 1;
        // right top corner (5, 1)
        // right bottom corner (5, -1)
        double right = left + width;
        double bottom = top - heigth;

        Console.Write("Insert horizontal coordinata x = ");
        string takeX = Console.ReadLine();
        double x = double.Parse(takeX);
        Console.Write("Insert vertical coordinate y = ");
        string takeY = Console.ReadLine();
        double y = double.Parse(takeY);
        // this way we check if the point is inside the circle
        bool isInCircle = Math.Sqrt((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY)) <= radius;
        // this way we check if the point is inside the rectangle
        bool isInRectangle = (x >= left) && (x <= right) && (y <= top) && (y >= bottom);
        // isOutRectangle = (x < left) || (x > right) || (y > top) || (y < bottom)
        // !isInRectangle means not is in the rectangle which we need
        // && is for both conditions to be complete
        bool result = isInCircle && !isInRectangle;
        Console.WriteLine("The point is inside the circle and out of the rectangle: {0}", result);       
    }
}

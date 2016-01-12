using System;
// Which of the following values can be assigned to a variable of type float and which 
// to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

class FloatOrDouble
{
    // float can hold 7 digits after point
    // double can hold 15 digits after point
    static void Main()
    {
        double var1 = 34.567839023;
        float var2 = 12.345f;
        float var3 = 8923.1234857f;
        float var4 = 3456.091f;

        Console.WriteLine("{0, 12} {1, 13}", var1, "from double type");
        Console.WriteLine("{0, 12} {1, 13}", var2 , "from float type");
        Console.WriteLine("{0, 12} {1, 13}", var3 , "from float type");
        Console.WriteLine("{0, 12} {1, 13}", var4 , "from float type");

    }
}


using System;

// Write a program that reads 3 numbers:
// integer a (0 <= a <= 500)
// floating-point b
// floating-point c
// The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
// The number a should be printed in hexadecimal, left aligned
// Then the number a should be printed in binary form, padded with zeroes
// The number b should be printed with 2 digits after the decimal point, right aligned
// The number c should be printed with 3 digits after the decimal point, left aligned.


class FormattingNumbers
{
 
    static void Main()
    {
        string takeA;
        int a;
        do
        {
            Console.Write("Insert integer number between 0 and 500: a = ");
            takeA = Console.ReadLine();
            a = int.Parse(takeA);
        } while (a < 0 || a > 500);

        Console.Write("Incert floating point number: b = ");
        string takeB = Console.ReadLine();
        float b = float.Parse(takeB);
        Console.Write("Insert floating point number: c = ");
        string takeC = Console.ReadLine();
        float c = float.Parse(takeC);

        Console.Write("{0,-10:X}", a);
        takeA = Convert.ToString(a, 2);
        Console.Write(" |{0,10}| ", takeA.PadLeft(10, '0'));
        Console.Write("{0,10:F2}", b);
        Console.WriteLine(" |{0, -10:F3}| ", c);
    }

}

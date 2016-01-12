using System;

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Binary: ");
        string binaryNumber = Console.ReadLine();
        long number = int.Parse(binaryNumber);
        double sum = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            long lastDigit = number % 10; // get the last digit
            sum = sum + lastDigit * (Math.Pow(2, i));
            number = number / 10; //remove the last digit
        }

        Console.WriteLine("Decimal: {0}", sum);
    }
}

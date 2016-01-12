using System;

// Write an expression that checks for given integer if its third digit from right-to-left is 7.
class ThirdDigitIs7
{
    static void Main()
    {
        //example number is 1035
        //1035 % 10 = 5 - 1)digit
        //1035 / 10 = 103
        //103 % 10 = 3 - 2)digit
        //103 / 10 = 10
        //10 % 10 = 0 - 3)digit
        //10 / 10 = 1 - 4)digit

        Console.WriteLine("Insert number");
        string takeNumber = Console.ReadLine();
        int number = int.Parse(takeNumber);
        int digit = 0;
        bool thirdDigitIs7 = false;
        // loop with 3 steps because I want to stop on 3-th digit
        for (int i = 1; i <= 3; i++)
        {
            digit = number % 10;
            number = number / 10;
            Console.WriteLine(i + ") Digit = " + digit);
            Console.WriteLine("Number = " + number);
        }
        if (digit != 0 && digit % 7 == 0)
        {
            thirdDigitIs7 = true;
        }
        Console.WriteLine("Is third digit equal to 7: {0}", thirdDigitIs7);
    }
}

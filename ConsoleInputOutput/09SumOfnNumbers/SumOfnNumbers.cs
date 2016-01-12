using System;

// Write a program that enters a number n and after that enters more n numbers and calculates and prints 
// their sum
class SumOfnNumbers
{
    static void Main()
    {
        Console.Write("How many numbers do you want to calculate their sum?\nn = ");
        string takeN = Console.ReadLine();
        double n = double.Parse(takeN);
        string takeNumber;
        double number;
        double sum = 0;
        Console.WriteLine("Insert each number");
        for (int i = 1; i <= n; i++)
        {
            Console.Write("number {0} = ", i);
            takeNumber = Console.ReadLine();
            number = double.Parse(takeNumber);
            sum += number;
        }
        Console.WriteLine("Sum of the insert numbers is: {0}", sum);

    }
}

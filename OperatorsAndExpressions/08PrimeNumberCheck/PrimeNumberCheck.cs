using System;

// Write an expression that checks if given positive integer number n (n = 100) 
//is prime (i.e. it is divisible without remainder only to itself and 1)

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Insert number");
        string takeNumber = Console.ReadLine();
        int number = int.Parse(takeNumber);
        bool isPrime = true;
        int result;
        // 2 is first prime number
        if (number <= 1)
        {
            isPrime = false;
        }
        for (int i = 2; i <= Math.Sqrt(number) && isPrime == true; i++)
        {
            result = number % i;
            if (result == 0)
            {
                isPrime = false;
            }
        }
        Console.WriteLine("Is {0} prime number? -> {1}", number, isPrime);
    }
}

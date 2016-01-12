using System;

//You are given n integers(given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
//Examples:
//numbers    | result
//2 1 1 6 3	 | yes
//product = 6
	
//3 10 4 6 5 1	| yes
//product = 60	

//2 4 2 5 5 | yes
//product = 20

//4 3 2 5 2	 | no
//odd_product = 16
//even_product = 15

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers on single line separated by space:");
        string numbers = Console.ReadLine();
        string[] numbersArray = numbers.Split(' ');
        long oddProduct = 1;
        long evenProduct = 1;

        for (int i = 0; i < numbersArray.Length; i += 2)
        {
            oddProduct *=  int.Parse(numbersArray[i]);
        }

        for (int i = 1; i < numbersArray.Length; i += 2)
        {
            evenProduct *= int.Parse(numbersArray[i]);
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}


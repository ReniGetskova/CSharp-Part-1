﻿using System;

// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
// on a single line, separated by a space.

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Program that prints numbers from 1 to n");
        Console.Write("Please insert number: n = ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}

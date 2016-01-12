using System;

// Write a program to read your birthday from the console and print how old you are now and 
// how old you will be after 10 years.
class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("How old are you?");
        int myAge = Convert.ToInt32(Console.ReadLine());
        //validation for correct age
        while (myAge < 0 || myAge > 100)
        {
            Console.WriteLine("Please insert correct age:");
            myAge = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("After 10 years you will be " + (myAge + 10) + " years old");
    }
}

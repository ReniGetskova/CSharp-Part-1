using System;

// Declare two string variables and assign them with Hello and World
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

class StringsAndObjects
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object concatStrings = firstString + " " + secondString;
        // casting object to string
        string thirdString = (string)concatStrings;
        Console.WriteLine("Casting object to string and print the result: {0}", thirdString);
    }

}


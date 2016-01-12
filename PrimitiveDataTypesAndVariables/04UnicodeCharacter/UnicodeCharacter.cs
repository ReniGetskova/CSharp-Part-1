using System;

// Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
// using the \u00XX syntax, and then print it.

class UnicodeCharacter
{
    static void Main()
    {
        int varInt = 42;
        Console.WriteLine("Fist way for printing character on position 42 -> {0} <- by casting to char", (char)varInt);
        char varChar = '\u002A';
        // 42 dec = 2A hex
        Console.WriteLine("Second way for printing character on position 42 -> {0} <- using unicode", varChar);
    }
}

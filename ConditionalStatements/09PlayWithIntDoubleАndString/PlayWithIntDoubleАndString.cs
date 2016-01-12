using System;

// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
// If the variable is int or double, the program increases it by one.
// If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.

class PlayWithIntDoubleАndString
{
    static void Main()
    {
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Please choose a type: ");
        string choise = Console.ReadLine();
        int intChoise;
        double doubleChoise;
        string stringChoise;
        switch (choise)
        {
            case "1":
                Console.Write("Please enter a int: ");
                intChoise = int.Parse(Console.ReadLine());
                intChoise++;
                Console.WriteLine(intChoise);
                break;
            case "2":
                Console.Write("Please enter a double: ");
                doubleChoise = double.Parse(Console.ReadLine());
                doubleChoise++;
                Console.WriteLine(doubleChoise);
                break;
            case "3":
                Console.Write("Please enter a string: ");
                stringChoise = Console.ReadLine();
                Console.WriteLine(stringChoise + "*");
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        }
    }
}

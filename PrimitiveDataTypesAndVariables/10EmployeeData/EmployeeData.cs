using System;

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//    First name
//    Last name
//    Age (0...100)
//    Gender (m or f)
//    Personal ID number (e.g. 8306112507)
//    Unique employee number (27560000…27569999)

//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names. Print the data at the console.
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string secondName = "Georgiev";
            byte age = 25;
            char gender = 'm';
            ulong pesonalID = 8306112507;
            ulong employeeID = 2756000027569999;
            Console.WriteLine("First Name: {0,5}", firstName);
            Console.WriteLine("Second Name: {0,5}", secondName);
            Console.WriteLine("Age: {0,10}", age);
            Console.WriteLine("Gender: {0,6}", gender);
            Console.WriteLine("Personal ID: {0,10}", pesonalID);
            Console.WriteLine("Employee ID: {0,14}", employeeID);
        }
    }


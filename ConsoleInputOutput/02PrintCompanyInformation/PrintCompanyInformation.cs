using System;

// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.


class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("What is your company's name?");
        string companyName = Console.ReadLine();
        Console.WriteLine("What is your company's address?");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("What is company's phone number?");
        Console.Write("+359 ");
        string companyPhone = "+359 " + Console.ReadLine();
        Console.WriteLine("What is company's fax number?");
        Console.WriteLine("If there is no fax input 2");
        string companyFax = Console.ReadLine();
        Console.WriteLine("What is company's web site?");
        string companyWebSite = Console.ReadLine();
        Console.WriteLine("What is manager's first name?");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("What is manager's last name?");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("What is manager's age?");
        string managerAge = Console.ReadLine();
        Console.WriteLine("What is manager's phone number?");
        Console.Write("+359 ");
        string managerPhone = "+ 359 " + Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhone);
        if (string.Equals(companyFax, "2"))
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", companyFax);
        }
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}

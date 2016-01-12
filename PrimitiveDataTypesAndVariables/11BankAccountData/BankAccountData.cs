using System;

// A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
// bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate 
// data types and descriptive names.

class BankAccountData
{
    static void Main()
    {
        string firstName = "Peter";
        string middleName = "Ivanov";
        string lastName = "Georgiev";
        decimal balance = 2355.22M;
        string bankName = "DCK";
        string iban = "BG80BNBG96611020345678";
        ulong creditCard1 = 5500005555555559;
        ulong creditCard2 = 9834563043827496;
        ulong creditCard3 = 2343446645684465;
        Console.WriteLine("Information for a single bank account");
        Console.WriteLine();
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Middle name: {0}", middleName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);        
        Console.WriteLine("First credit card number: {0}", creditCard1);
        Console.WriteLine("Second credit card number: {0}", creditCard2);
        Console.WriteLine("Third credit card number: {0}", creditCard3);


    }
}

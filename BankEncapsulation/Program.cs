using BankEncapsulation;

BankAccount client1 = new BankAccount(1000); //note the account starts out with $1,000 in it

//for proof my default constructor works, uncomment this:

//BankAccount client2 = new BankAccount();
//Console.WriteLine($"Balance of client 2: {client2.GetBalance()}\n");

bool cont = true;

while (cont == true)
{
    bool invalid1 = false;

    Console.WriteLine("Please select an option (1, 2, or 3)\n1 - Make a deposit\n2 - Make a withdrawal\n3 - Get your balance");

    do
    {
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Please enter your deposit amount in numerals.");
                double.TryParse(Console.ReadLine(), out double deposit);
                client1.Deposit(deposit);
                invalid1 = false;
                break;
            case "2":
                Console.WriteLine("Please enter your withdrawal amount in numerals.");
                double.TryParse(Console.ReadLine(), out double withdrawal);
                client1.Withdraw(withdrawal);
                invalid1 = false;
                break;
            case "3":
                Console.WriteLine($"Your balance: ${client1.GetBalance()}");
                invalid1 = false;
                break;
            default:
                Console.WriteLine("Invalid selection");
                invalid1 = true;
                break;
        }
    } while (invalid1 == true);

    bool invalid2 = false;

    do
    {
        Console.WriteLine("\nWould you like to continue?");
        string? userInput = Console.ReadLine().ToLower();
        if (userInput == "yes" || userInput == "y")
        {
            cont = true;
            invalid2 = false;
        }
        else if (userInput == "no" || userInput == "n")
        {
            cont = false;
            invalid2 = false;
        }
        else
        {
            Console.WriteLine("Invalid selection");
            invalid2 = true;
        } 
    } while (invalid2 == true);

    Console.WriteLine();
}
using bytebank.Employees;
using bytebank.Utils;
using bytebank.InternalSystem;
using bytebank.CommercialPartnership;
using bytebank.Clients;
using bytebank.Accounts;
using bytebank.CustomExceptions;
using System.Runtime.Serialization.Formatters;
using System.Collections;
using System.Security.AccessControl;


//Clients
Client adriana = new Client("Adriana", "123546789", "Marketing");
Client bruno = new Client("Bruno", "456789132", "Developer");
Client carlos = new Client("Carlos", "789456132", "Sales");

//Accounts
CheckingAccount adrianaAccount = new CheckingAccount(adriana, 123, 123456);
CheckingAccount brunoAccount = new CheckingAccount(bruno, 465, 456789);
CheckingAccount carlosAccount = new CheckingAccount(carlos, 789, 789123);

List<CheckingAccount> _accountsList = new List<CheckingAccount>() { carlosAccount, adrianaAccount, brunoAccount };

try
{
    ShowMenu();
}
catch (MenuInvalidOptionException exception)
{
    Console.WriteLine(exception.Message);
}

void ShowMenu()
{
    Console.Clear();

    string menu = $"*-------------------------------*\n" +
                  $"|       Customer Service        |\n" +
                  $"*-------------------------------*\n" +
                  $"|    1 - Create a new account   |\n" +
                  $"|    2 - Show all accounts      |\n" +
                  $"|    3 - Delete account         |\n" +
                  $"|    4 - Sort accounts          |\n" +
                  $"|    5 - Search account         |\n" +
                  $"|    6 - Exit system            |\n" +
                  $"*-------------------------------*\n\n";

    Console.WriteLine(menu);
    char option = Console.ReadLine()[0];
    selectOption(option);
}

void selectOption(char option)
{
    Console.Clear();

    switch (option)
    {
        case '1':
            CreateAccount();
            goto default;
        case '2':
            ShowAllAccounts();
            goto default;
        case '3':
            RemoveAccounts();
            goto default;
        case '4':
            SortAccounts();
            goto default;
        case '5':
            FindAccount();
            goto default;
        case '6':
            ExitProgram();
            break;
        default: 
            ShowMenu();
            break;
    }
}

void CreateAccount()
{
    Console.Clear();

    string createAccountTitle = $"*------------------------*\n" +
                                $"| Creating a new account |\n" +
                                $"*------------------------*\n\n";

    Console.WriteLine(createAccountTitle);
    Console.WriteLine("Please, inform the account data:\n");

    Console.Write("Account number: ");
    int accountNumber = int.Parse(Console.ReadLine());

    Console.Write("Agency number: ");
    int agencyNumber = int.Parse(Console.ReadLine());

    Console.Write("Holder's name: ");
    string holderName = Console.ReadLine();

    Console.Write("Holder's CPF: ");
    string holderCPF = Console.ReadLine();

    Console.Write("Holder's job: ");
    string holderJob = Console.ReadLine();

    Client client = new Client(holderName, holderCPF, holderJob);

    CheckingAccount account = new CheckingAccount(client, agencyNumber, accountNumber);

    _accountsList.Add(account);
    Console.WriteLine(_accountsList.Count);
    Console.WriteLine("\n* Account created successfully *");
    Console.ReadKey();
}

void ShowAllAccounts()
{
    string showAllAccountsTitle = $"*------------------------*\n" +
                                  $"|  Showing all accounts  |\n" +
                                  $"*------------------------*\n\n";

    Console.WriteLine(showAllAccountsTitle);
    if (_accountsList.Count <= 0)
    {
        Console.WriteLine("There aren't accounts to show...");
    } 
    else
    {
        foreach(CheckingAccount account in _accountsList)
        {
            Console.WriteLine(account);
        }
    }

    Console.ReadKey();
}

void ExitProgram()
{
    Console.Clear();
    Console.WriteLine("You left the system...");
}

void RemoveAccounts()
{
    string removeAccountsTitle = $"*-----------------------*\n" +
                                 $"|  Removing an account  |\n" +
                                 $"*-----------------------*\n\n";

    Console.WriteLine(removeAccountsTitle);
    Console.Write("Inform the account number: ");
    int accountNumber = int.Parse(Console.ReadLine());
    var account = _accountsList.Find((item) => item.AccountNumber == accountNumber);
    if (account != null)
    {
        _accountsList.Remove(account);
        Console.Write("The account was removed from the list.");
    }
    else
    {
        Console.WriteLine("The specified account was not found.");
    }
    Console.ReadKey();
}

void SortAccounts()
{
    string sortAccountsTitle = $"*--------------------*\n" +
                               $"|  Sorting accounts  |\n" +
                               $"*--------------------*\n\n";

    Console.WriteLine(sortAccountsTitle);
    _accountsList.Sort();
    Console.WriteLine("Accounts sorted.");
    Console.ReadKey();
}

void FindAccount()
{
    string searchAccountTitle = $"*-------------------------*\n" +
                                $"|  Search for an account  |\n" +
                                $"*-------------------------*\n\n";

    Console.WriteLine(searchAccountTitle);
    Console.WriteLine("Do you want to search based on what information?\n" +
        "1 - Account number;\n" +
        "2 - Holder's CPF.\n");
    char option = Console.ReadLine()[0];
    CheckingAccount account = null;
    switch (option)
    {
        case '1':
            Console.Write("\nInform the account number you want to search for: ");
            int accountNumber = int.Parse(Console.ReadLine());
            account = _accountsList.Find(item => item.AccountNumber == accountNumber);
            break;
        case '2':
            Console.Write("\nInform the holder's account CPF number you want to search for: ");
            string cpf = Console.ReadLine();
            account = _accountsList.Find(item => item.Holder.Cpf == cpf);
            break;
    }
    if (account == null)
    {
        Console.WriteLine("The search return 0 results. The specified account was not found.");
    }
    else
    {
        Console.WriteLine(account);
    }

    Console.ReadKey();
}
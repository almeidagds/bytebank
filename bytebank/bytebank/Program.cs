using bytebank.Employees;
using bytebank.Utils;
using bytebank.InternalSystem;
using bytebank.CommercialPartnership;
using bytebank.Clients;
using bytebank.Accounts;
using bytebank.CustomExceptions;
using System.Runtime.Serialization.Formatters;
using System.Collections;

void CustomerService()
{

}

void ShowMenu()
{
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
    string option = Console.ReadLine();
    selectOption(option);
}

void selectOption(string option)
{
        switch (option)
        {
            case "1": CreateAccount();
                break;
            case "2": ShowAllAccounts();
                break;
        }
}

ArrayList _accountsList = new ArrayList();

ShowMenu();


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
        Console.ReadKey();
    } else
    {
        foreach(CheckingAccount account in _accountsList)
        {
            string accountInformation = $"Holder: {account.Holder.Name}\n" +
                                        $"Holder's CPF: {account.Holder.Cpf}\n" +
                                        $"Holder's job: {account.Holder.Job}\n" +
                                        $"Account number: {account.AccountNumber}\n" +
                                        $"Agency number: {account.Agency}\n\n";
        }
    }

    Console.ReadKey();
}
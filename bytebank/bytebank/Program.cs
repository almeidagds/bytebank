using bytebank.Employees;
using bytebank.Utils;
using bytebank.InternalSystem;
using bytebank.CommercialPartnership;
using bytebank.Clients;
using bytebank.Accounts;
using bytebank.CustomExceptions;
using System.Runtime.Serialization.Formatters;

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
                  $"*-------------------------------*\n";

    Console.WriteLine(menu);
}

void selectOption(string option)
{
        switch (option)
        {
            case "1":
                break;
        }
}

ShowMenu();
using bytebank.Employees;
using bytebank.Utils;
using bytebank.InternalSystem;
using bytebank.CommercialPartnership;
using bytebank.Clients;
using bytebank.Accounts;
using bytebank.CustomExceptions;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Welcome to Bytebank Administrator.");

CheckingAccount[] accountsList = new CheckingAccount[]
{
    new CheckingAccount(
            new Client("Gabriel", "12345678912", "Developer"),
            0124,
            12345678
        ),
    new CheckingAccount(
            new Client("Jorge", "12345678912", "QA Analyst"),
            0124,
            12345678
        ),
    new CheckingAccount(
            new Client("Pedro", "12345678912", "Manager"),
            0124,
            12345678
        )
};

foreach (CheckingAccount account in accountsList)
{
    Console.WriteLine(account);
}
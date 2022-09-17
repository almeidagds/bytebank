using bytebank.Employees;
using bytebank.Utils;
using bytebank.InternalSystem;
using bytebank.CommercialPartnership;
using bytebank.Clients;
using bytebank.Accounts;
using bytebank.CustomExceptions;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Welcome to Bytebank Administrator.");

string[] wordsArray = new string[5];

for (int i = 0; i < wordsArray.Length; i++)
{
    Console.Write($"Type {i + 1}th word: ");
    wordsArray[i] = Console.ReadLine();
}

Console.Write("Type the word to be searched: ");
var search = Console.ReadLine();

foreach (var word in wordsArray)
{
    if (word.Equals(search))
    {
        Console.WriteLine($"Word founded: {search}");
    }
    else
    {
        Console.WriteLine($"Word '{search}' was not found.");
    }
}
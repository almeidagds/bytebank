using bytebank.Employees;
using bytebank.Utils;
using bytebank.InternalSystem;
using bytebank.CommercialPartnership;
using bytebank.Clients;
using bytebank.Accounts;
using bytebank.CustomExceptions;

Console.WriteLine("Welcome to Bytebank Administrator.");

int[] ages = new int[5];

ages[0] = 1;
ages[1] = 2;
ages[2] = 3;
ages[3] = 4;
ages[4] = 5;

Console.WriteLine($"Age's array size: {ages.Length}");

for (int i = 0; i < ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}
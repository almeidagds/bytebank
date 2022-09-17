using bytebank.Employees;
using bytebank.Utils;
using bytebank.InternalSystem;
using bytebank.CommercialPartnership;
using bytebank.Clients;
using bytebank.Accounts;
using bytebank.CustomExceptions;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Welcome to Bytebank Administrator.");

Array array = Array.CreateInstance(typeof(double), 5);

array.SetValue(5.9, 0);
array.SetValue(4.4, 1);
array.SetValue(7.3, 2);
array.SetValue(3.7, 3);
array.SetValue(9.2, 4);

void TestMedian(Array array)
{
    if (array == null || array.Length == 0)
    {
        Console.WriteLine("Array is empty or null.");
    }
    
    double[] orderedNumbers = (double[])array.Clone();

    Array.Sort(orderedNumbers);

    int middle = orderedNumbers.Length / 2;

    double median = (orderedNumbers.Length % 2 == 0) ? orderedNumbers[middle] : (orderedNumbers[middle] + orderedNumbers[middle - 1]) / 2;
}
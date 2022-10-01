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
using bytebank.Attendance;

DateTime paymentFinalDate = new DateTime(2022,12,05);
DateTime currentDate = DateTime.Now;
TimeSpan diff = paymentFinalDate - currentDate;

Console.WriteLine($"Vencimento em: {GetLegibleTimeInterval(diff)}.");

static string GetLegibleTimeInterval(TimeSpan time)
{
    return time.Days + " dias";
}
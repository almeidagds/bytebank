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
using Humanizer;

DateTime paymentFinalDate = new DateTime(2022,10,10);
DateTime currentDateTime = DateTime.Now;

TimeSpan timeDiff = paymentFinalDate - currentDateTime;

string message = $"Due on {TimeSpanHumanizeExtensions.Humanize(timeDiff)}.";

Console.WriteLine(message);
Console.ReadLine();
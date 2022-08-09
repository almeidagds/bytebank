using bytebank;

Console.WriteLine("Welcome to ByteBank!");

CheckingAccount firstAccount = new CheckingAccount();
firstAccount.holder = "Gabriel de Almeida";
firstAccount.account = "10123-X";
firstAccount.agencyNumber = 23;
firstAccount.agencyName = "Central Agency";
firstAccount.balance = 102.30;

CheckingAccount secondAccount = new CheckingAccount();

Console.WriteLine($"Holder: {firstAccount.holder}");
Console.WriteLine($"Account: {firstAccount.account}");
Console.WriteLine($"Agency Number: {firstAccount.agencyNumber}");
Console.WriteLine($"Agency Name: {firstAccount.agencyName}");
Console.WriteLine($"Balance: {firstAccount.balance}");

Console.ReadKey();
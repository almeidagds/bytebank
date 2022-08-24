using bytebank;

Console.WriteLine("Welcome to ByteBank!");

CheckingAccount account = new CheckingAccount();

account.setBalance(-10);
Console.WriteLine(account.balance);

Console.ReadKey();
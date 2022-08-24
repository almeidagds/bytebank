using bytebank;

Console.WriteLine("Welcome to ByteBank!");

CheckingAccount account = new CheckingAccount();

account.SetBalance(-10);
Console.WriteLine(account.GetBalance());

Console.ReadKey();
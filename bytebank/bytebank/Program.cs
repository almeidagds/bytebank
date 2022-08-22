using bytebank;

Console.WriteLine("Welcome to ByteBank!");

Client client = new Client();

client.name = "Gabriel";
client.cpf = "12345678912";
client.job = "Desenvolvedor Júnior";

CheckingAccount account = new CheckingAccount();

account.holder = client;
account.account = "251456-X";
account.agencyNumber = 35;
account.agencyName = "Central Agency";

Console.WriteLine($"Nome do cliente: {client.name}");
Console.WriteLine($"Nome do titular: {account.holder.name}");

Console.ReadKey();
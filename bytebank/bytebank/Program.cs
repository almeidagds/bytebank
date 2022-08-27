using bytebank.Employees;
using bytebank.Utils;

Console.WriteLine("Welcome to Bytebank Administrator.");

BonusManager manager = new BonusManager();

Employee pedro = new Employee("78954612345");
pedro.Name = "Pedro";
pedro.Salary = 2000;
Console.WriteLine($"Total de funcionários: {Employee.NumberOfEmployees}");

CEO paula = new CEO("45678912312");
paula.Name = "Paula";
paula.Salary = 5000;
Console.WriteLine($"Total de funcionários: {Employee.NumberOfEmployees}");

Employee andre = new CEO("45612345678");
andre.Name = "André";

Console.WriteLine($"Total de funcionários: {Employee.NumberOfEmployees}");

Console.WriteLine($"Bonificação do {pedro.Name}: {pedro.getBonus()}");
Console.WriteLine($"Bonificação da {paula.Name}: {paula.getBonus()}");

manager.Registry(pedro);
manager.Registry(paula);

Console.WriteLine($"Total de bonificações dos funcionários: {manager.GetBonusTotal()}");
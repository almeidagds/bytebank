using bytebank.Employees;
using bytebank.Utils;

Console.WriteLine("Welcome to Bytebank Administrator.");

BonusManager manager = new BonusManager();

Employee pedro = new Employee("78954612345", 2000);
pedro.Name = "Pedro";

CEO paula = new CEO("45678912312", 5000);
paula.Name = "Paula";

Employee andre = new CEO("45612345678", 3000);
andre.Name = "André";

manager.Registry(pedro);
manager.Registry(paula);
manager.Registry(andre);

andre.RiseSalary();
pedro.RiseSalary();

Console.WriteLine($"Novo salário do André {andre.Salary}");
Console.WriteLine($"Novo salário do Pedro {pedro.Salary}");
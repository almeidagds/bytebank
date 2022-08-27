using bytebank.Employees;
using bytebank.Utils;

Console.WriteLine("Welcome to Bytebank Administrator.");

BonusManager manager = new BonusManager();

Employee pedro = new Employee();
pedro.Name = "Pedro";
pedro.Cpf = "78954612345";
pedro.Salary = 2000;

CEO paula = new CEO();
paula.Name = "Paula";
paula.Cpf = "45678912312";
paula.Salary = 5000;

Employee andre = new CEO();
using bytebank.Employees;

Console.WriteLine("Welcome to Bytebank Administrator.");

Employee joao = new Employee();

joao.Name = "João";
joao.Cpf = "12345678945";
joao.Salary = 1800;

Console.WriteLine($"Bonificação: {joao.getBonus()}");
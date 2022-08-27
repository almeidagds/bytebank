using bytebank.Employees;
using bytebank.Utils;

Console.WriteLine("Welcome to Bytebank Administrator.");

CalculateBonus();

void CalculateBonus()
{
    BonusManager manager = new BonusManager();

    Designer pedro = new Designer("Pedro", "123.456.789-12");

    Developer gabriel = new Developer("Gabriel", "432.764.159-77");

    CEO paula = new CEO("Paula", "456.789.123-78");

    Assistant igor = new Assistant("Igor", "456.754.123-98");

    AccountManager camila = new AccountManager("Camila", "512.456.784-15");

    manager.Registry(pedro);
    manager.Registry(gabriel);
    manager.Registry(paula);
    manager.Registry(igor);
    manager.Registry(camila);

    Console.WriteLine($"Bonus total: {manager.GetTotalBonus()}");
}
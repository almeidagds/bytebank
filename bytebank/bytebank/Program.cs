using bytebank.Employees;
using bytebank.Utils;
using bytebank.InternalSystem;
using bytebank.CommercialPartnership;
using bytebank.Clients;

Console.WriteLine("Welcome to Bytebank Administrator.");


UseSystem();

void CalculateBonus()
{
    BonusManager manager = new BonusManager();

    Designer pedro = new Designer("Pedro", "123.456.789-12");

    Developer gabriel = new Developer("Gabriel", "432.764.159-77");

    CEO paula = new CEO("Paula", "456.789.123-78", "123");

    Assistant igor = new Assistant("Igor", "456.754.123-98");

    AccountManager camila = new AccountManager("Camila", "512.456.784-15", "teste3");

    manager.Registry(pedro);
    manager.Registry(gabriel);
    manager.Registry(paula);
    manager.Registry(igor);
    manager.Registry(camila);

    Console.WriteLine($"Bonus total: {manager.GetTotalBonus()}");
}

void UseSystem()
{
    InternalSystem internalSystem = new InternalSystem();

    CEO roberta = new CEO("Roberta", "456.789.123-78", "123");

    AccountManager ursula = new AccountManager("Ursula", "512.456.784-15", "teste3");

    CommercialPartner joao = new CommercialPartner("senha1234");

    internalSystem.Login(roberta, "123");

    internalSystem.Login(ursula, "teste3");

    internalSystem.Login(joao, "senha1234");

    try
    {
        int zero = 0;
        int divideByZero = 4 / zero;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("You can't divide by zero.");
    }
}
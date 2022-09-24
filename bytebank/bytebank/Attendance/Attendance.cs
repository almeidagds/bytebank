using bytebank.Accounts;
using bytebank.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Attendance
{
    public class Attendance
    {

        public Attendance()
        {
            //Clients
            Client adriana = new Client("Adriana", "123546789", "Marketing");
            Client bruno = new Client("Bruno", "456789132", "Developer");
            Client carlos = new Client("Carlos", "789456132", "Sales");

            //Accounts
            CheckingAccount adrianaAccount = new CheckingAccount(adriana, 123);
            CheckingAccount brunoAccount = new CheckingAccount(bruno, 465);
            CheckingAccount carlosAccount = new CheckingAccount(carlos, 789);

            this._accountsList = new List<CheckingAccount>() { carlosAccount, adrianaAccount, brunoAccount };
        }

        private List<CheckingAccount> _accountsList;

        public void ShowMenu()
        {
            Console.Clear();

            string menu = $"*-------------------------------*\n" +
                          $"|       Customer Service        |\n" +
                          $"*-------------------------------*\n" +
                          $"|    1 - Create a new account   |\n" +
                          $"|    2 - Show all accounts      |\n" +
                          $"|    3 - Delete account         |\n" +
                          $"|    4 - Sort accounts          |\n" +
                          $"|    5 - Search account         |\n" +
                          $"|    6 - Exit system            |\n" +
                          $"*-------------------------------*\n\n";

            Console.WriteLine(menu);
            char option = Console.ReadLine()[0];
            selectOption(option);
        }

        private void selectOption(char option)
        {
            Console.Clear();

            switch (option)
            {
                case '1':
                    CreateAccount();
                    goto default;
                case '2':
                    ShowAllAccounts();
                    goto default;
                case '3':
                    RemoveAccounts();
                    goto default;
                case '4':
                    SortAccounts();
                    goto default;
                case '5':
                    FindAccount();
                    goto default;
                case '6':
                    ExitProgram();
                    break;
                default:
                    ShowMenu();
                    break;
            }
        }

        private void CreateAccount()
        {
            Console.Clear();

            string createAccountTitle = $"*------------------------*\n" +
                                        $"| Creating a new account |\n" +
                                        $"*------------------------*\n\n";

            Console.WriteLine(createAccountTitle);
            Console.WriteLine("Please, inform the account data:\n");

            Console.Write("Agency number: ");
            int agencyNumber = int.Parse(Console.ReadLine());

            Console.Write("Holder's name: ");
            string holderName = Console.ReadLine();

            Console.Write("Holder's CPF: ");
            string holderCPF = Console.ReadLine();

            Console.Write("Holder's job: ");
            string holderJob = Console.ReadLine();

            Client client = new Client(holderName, holderCPF, holderJob);

            CheckingAccount account = new CheckingAccount(client, agencyNumber);

            _accountsList.Add(account);
            Console.WriteLine("\n* Account created successfully *");
            Console.ReadKey();
        }

        private void ShowAllAccounts()
        {
            string showAllAccountsTitle = $"*------------------------*\n" +
                                          $"|  Showing all accounts  |\n" +
                                          $"*------------------------*\n\n";

            Console.WriteLine(showAllAccountsTitle);
            if (_accountsList.Count <= 0)
            {
                Console.WriteLine("There aren't accounts to show...");
            }
            else
            {
                foreach (CheckingAccount account in _accountsList)
                {
                    Console.WriteLine(account);
                }
            }

            Console.ReadKey();
        }

        private void ExitProgram()
        {
            Console.Clear();
            Console.WriteLine("You left the system...");
        }

        private void RemoveAccounts()
        {
            string removeAccountsTitle = $"*-----------------------*\n" +
                                         $"|  Removing an account  |\n" +
                                         $"*-----------------------*\n\n";

            Console.WriteLine(removeAccountsTitle);
            Console.Write("Inform the account number: ");
            string accountNumber = Console.ReadLine();
            var account = _accountsList.Find((item) => item.AccountNumber.Equals(accountNumber));
            if (account != null)
            {
                _accountsList.Remove(account);
                Console.Write("The account was removed from the list.");
            }
            else
            {
                Console.WriteLine("The specified account was not found.");
            }
            Console.ReadKey();
        }

        private void SortAccounts()
        {
            string sortAccountsTitle = $"*--------------------*\n" +
                                       $"|  Sorting accounts  |\n" +
                                       $"*--------------------*\n\n";

            Console.WriteLine(sortAccountsTitle);
            _accountsList.Sort();
            Console.WriteLine("Accounts sorted.");
            Console.ReadKey();
        }

        private void FindAccount()
        {
            string searchAccountTitle = $"*-------------------------*\n" +
                                        $"|  Search for an account  |\n" +
                                        $"*-------------------------*\n\n";

            Console.WriteLine(searchAccountTitle);
            Console.WriteLine("Do you want to search based on what information?\n" +
                "1 - Account number;\n" +
                "2 - Holder's CPF.\n");
            char option = Console.ReadLine()[0];
            CheckingAccount account = null;
            switch (option)
            {
                case '1':
                    Console.Write("\nInform the account number you want to search for: ");
                    string accountNumber = Console.ReadLine();
                    account = _accountsList.Find(item => item.AccountNumber.Equals(accountNumber));
                    break;
                case '2':
                    Console.Write("\nInform the holder's account CPF number you want to search for: ");
                    string cpf = Console.ReadLine();
                    account = _accountsList.Find(item => item.Holder.Cpf == cpf);
                    break;
            }
            if (account == null)
            {
                Console.WriteLine("The search return 0 results. The specified account was not found.");
            }
            else
            {
                Console.WriteLine(account);
            }

            Console.ReadKey();
        }
    }
}

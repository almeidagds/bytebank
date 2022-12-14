using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using bytebank.Clients;
using bytebank.CustomExceptions;

namespace bytebank.Accounts
{   
    /// <summary>
    /// This class define a ByteBank Checking Account.
    /// </summary>
    public class CheckingAccount : IComparable<CheckingAccount>
    {
        public Client Holder { get; set; }
        public int Agency { get; }
        public string AccountNumber { get; }
        public double Balance
        {
            get { return Balance; }
            set
            {
                if (value > 0) Balance = value;
            }
        }
        public static double OperationFee { get; private set; }
        public static int NumberOfAccounts { get; private set; }

        /// <summary>
        /// Create a instance of Checking Account.
        /// </summary>
        /// <param name="holder">Checking account's holder.</param>
        /// <param name="agency">Checking account's agency</param>
        /// <exception cref="ArgumentException"></exception>
        public CheckingAccount(Client holder, int agency)
        {
            Holder = holder;
            Agency = agency;
            AccountNumber = Guid.NewGuid().ToString().Substring(0, 8);
            Balance = 0;
            NumberOfAccounts++;
            OperationFee = 30 / NumberOfAccounts;

            if (agency <= 0)
            {
                throw new ArgumentException("The agency number can't be less or equal to zero.", nameof(agency));
            }
        }
        public void Withdraw(double value)
        {

            if (Balance >= value)
            {
                Balance -= value;
            }
            else
            {
                throw new InsufficientBalanceException("Insufficient balance.");
            }

        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public bool MakeWireTransfer(double value, CheckingAccount destinyAccount)
        {
            bool wireTransferWasSuccesfful = false;

            if (Balance >= value)
            {
                Balance -= value;
                destinyAccount.Deposit(value);
                wireTransferWasSuccesfful = true;
            }

            return wireTransferWasSuccesfful;
        }

        public int CompareTo(CheckingAccount? other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.AccountNumber.CompareTo(other.AccountNumber);
            }
        }

        public override string ToString()
        {
            string accountInformation = $"Holder: {this.Holder.Name}\n" +
                                        $"Holder's CPF: {this.Holder.Cpf}\n" +
                                        $"Holder's job: {this.Holder.Job}\n" +
                                        $"Account number: {this.AccountNumber}\n" +
                                        $"Agency number: {this.Agency}\n"; ;

            return accountInformation;
        }
    }
}
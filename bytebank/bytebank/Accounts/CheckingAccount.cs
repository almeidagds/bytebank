using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Clients;
using bytebank.CustomExceptions;

namespace bytebank.Accounts
{
    public class CheckingAccount : IComparable<CheckingAccount>
    {
        public Client Holder { get; set; }
        public int Agency { get; }
        public int AccountNumber { get; }
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

        public CheckingAccount(Client holder, int agency, int accountNumber)
        {
            Holder = holder;
            Agency = agency;
            AccountNumber = accountNumber;
            Balance = 0;
            NumberOfAccounts++;
            OperationFee = 30 / NumberOfAccounts;

            if (agency <= 0)
            {
                throw new ArgumentException("The agency number can't be less or equal to zero.", nameof(agency));
            }
            if (accountNumber <= 0)
            {
                throw new ArgumentException("The account number can't be less or equal to zero.", nameof(accountNumber));
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
    }
}
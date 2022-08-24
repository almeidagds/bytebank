namespace bytebank {
    public class CheckingAccount {

        private Client holder;
        private string account;
        private int agencyNumber;
        private string agencyName;
        private double balance;

        public CheckingAccount(int agencyNumber, string account) {
            AgencyNumber = agencyNumber;
            Account = account;
        }
        public bool Withdraw(double value) {
            if (balance < value || value < 0) {
                return false;
            }
            balance = balance - value;
            return true;
        }

        public void Deposit(double value) {
            balance = balance + value;
        }
        public bool Transfer(double value, CheckingAccount destiny) {
            if (balance < value || value <= 0) {
                return false;
            }

            balance = balance - value;
            destiny.balance = destiny.balance + value;
            return true;
        }

        public Client Holder
        {
            get;
            set;
        }

        public string Account
        {
            get
            {
                return account;
            }

            set
            {
                if (value != null)
                {
                    account = value;
                }
            }
        }

        public int AgencyNumber
        {
            get
            {
                return agencyNumber;
            }

            set
            {
                if (value >= 0)
                {
                    agencyNumber = value;
                }
            }
        }

        public string AgencyName
        {
            get;
            set;
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
            }
        }
    }   
}
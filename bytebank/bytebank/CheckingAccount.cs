namespace bytebank {
    public class CheckingAccount {
        public string holder;
        public string account;
        public int agencyNumber;
        public string agencyName;
        public double balance;
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
    }
}
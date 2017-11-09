namespace ClassroomA
{
    public class BankAccount
    {
        private static int _IDDispenser = 1;

        private string _ownerName;
        private int _accountID;
        private double _balance;
        private double _interestRate;

        public BankAccount(string ownerName, double interestRate)
        {
            _balance = 0;
            _accountID = _IDDispenser++;

            _ownerName = ownerName;
            _interestRate = interestRate;
        }
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public string OwnerName
        {
            get { return _ownerName; }
        }

        public int AccountID
        {
            get { return _accountID; }
        }

        public double InterestRate
        {
            get { return _interestRate; }
        }
    }
}
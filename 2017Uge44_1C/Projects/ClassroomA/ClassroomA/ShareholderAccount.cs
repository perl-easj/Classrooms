namespace ClassroomA
{
    public class ShareholderAccount : BankAccount
    {
        private double _bonusFactor;

        public ShareholderAccount(string ownerName, double interestRate, double bonusFactor) 
            : base(ownerName, interestRate)
        {
            _bonusFactor = bonusFactor;
        }
        public double BonusFactor
        {
            get { return _bonusFactor; }
        }
    }
}
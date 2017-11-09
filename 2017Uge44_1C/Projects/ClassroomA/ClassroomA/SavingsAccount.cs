namespace ClassroomA
{
    public class SavingsAccount : BankAccount
    {
        private int _bindingPeriod;

        public SavingsAccount(double interestRate, int bindingPeriod, string ownerName)
            : base(ownerName, interestRate)
        {
            _bindingPeriod = bindingPeriod;
        }

        public double BindingPeriod
        {
            get { return _bindingPeriod; }
        }
    }
}
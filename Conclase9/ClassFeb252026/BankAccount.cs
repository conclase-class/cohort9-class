namespace Conclase9.ClassFeb252026
{
    internal class BankAccount
    {
        private decimal _balance;

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(amount <= _balance)
            {
                _balance -= amount;
            }
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
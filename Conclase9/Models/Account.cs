namespace Conclase9.Models
{
    public class Account
    {
        private decimal balance;
        private string name;

        public decimal Balance
        { 
            get { return balance;  }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Balance cannot be less than 0");
                }

                balance = value;
            }
        }

        public string Name 
        {
            get { return  name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name can not empty");
                }

                name = value;
            } 
        }

        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new Exception("Amount can not be 0 or less");
            }

            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount can not be 0 or less");
            }

            balance -= amount;
        }

        public void GetBalance()
        {
            Console.WriteLine($"Your current balance is: $ {balance:F2}");
        }
    }
}

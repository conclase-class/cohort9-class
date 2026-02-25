namespace Conclase9.ClassFeb232026
{
    internal class Checkout
    {
        private readonly IPayment _payment;

        public Checkout(IPayment payment)
        {
            _payment = payment;
        }

        public void Process(decimal amount)
        {
            _payment.Pay(amount);
        }
    }
}
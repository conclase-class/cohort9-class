namespace Conclase9.ClassFeb232026
{
    internal class CashPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid NGN {amount} in cash.");
        }
    }
}
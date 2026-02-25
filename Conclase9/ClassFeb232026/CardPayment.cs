namespace Conclase9.ClassFeb232026
{
    internal class CardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid NGN {amount} with card");
        }
    }
}
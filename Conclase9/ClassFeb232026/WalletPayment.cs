namespace Conclase9.ClassFeb232026
{
    internal class WalletPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid NGN {amount} from wallet.");
        }
    }
}

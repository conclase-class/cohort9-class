namespace Implementations
{
    public class UserAddress : BaseEntity
    {
        public string FullAddress { get; set; } = default!;

        public void AddressDetails()
        {
            Console.WriteLine($"Id: {Id}\nCreated Date: {CreatedAt}\nAddress: {FullAddress}");
        }
    }
}

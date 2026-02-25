namespace Implementations
{
    public class Car : BaseEntity
    {
        public string Brand { get; set; } = default!;

        public void CarDetails()
        {
            Console.WriteLine($"Id: {Id}\nBrand: {Brand}\nManufacturing Date: {CreatedAt}");
        }
    }
}

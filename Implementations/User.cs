using Conclase9.Models;

namespace Implementations
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = default!;

        public void UserDetails()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nRegistration Date: {CreatedAt}");
        }
    }
}

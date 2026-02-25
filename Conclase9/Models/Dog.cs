namespace Conclase9.Models
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} barking...");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }
}

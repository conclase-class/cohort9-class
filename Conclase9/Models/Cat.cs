namespace Conclase9.Models
{
    public class Cat : Animal
    {
        public Cat() : base("Tom")
        {
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} meows");
        }

        public override void Eat()
        {
            Console.WriteLine("Cat is eating");
        }
    }
}

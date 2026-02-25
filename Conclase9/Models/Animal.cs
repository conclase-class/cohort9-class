namespace Conclase9.Models
{
    public class Animal
    {
        protected string Name { get; set; }

        public Animal()
        {
            
        }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating...");
        }
    }
}
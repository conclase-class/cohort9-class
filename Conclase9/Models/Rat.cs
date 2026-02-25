namespace Conclase9.Models
{
    public class Rat : Animal
    {
        public Rat() : base("Jerry")
        {
            
        }
        public void Gnaw()
        {
            Console.WriteLine($"{Name} ganwing");
        }

        public override void Eat()
        {
            Console.WriteLine("Rat is eating");
        }
    }
}

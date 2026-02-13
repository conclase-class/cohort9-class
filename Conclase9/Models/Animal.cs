namespace Conclase9.Models
{
    public class Animal
    {
        private static int _count;
        private string name;

        public string Name { get; set; } = default!;
        protected internal string Color { get; set; }

        public Animal()
        {
            _count++;
        }

        protected void Sleep()
        {
            Console.WriteLine("Sleeping");
        }

        private protected void Feed()
        {
            Console.WriteLine("Feeding");
        }

        public static void PrintPopulation()
        {
            Console.WriteLine($"There are {_count} animals in this Kingdom.");
        }
    }
}

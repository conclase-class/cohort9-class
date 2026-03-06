namespace Conclase9.Models
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Describe()
        {
            Console.WriteLine("This is a Circle");
        }
    }
}
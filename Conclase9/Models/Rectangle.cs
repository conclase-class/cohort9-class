namespace Conclase9.Models
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override void Describe()
        {
            Console.WriteLine("This is a rectangle");
        }
    }
}
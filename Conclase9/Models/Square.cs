namespace Conclase9.Models
{
    internal class Square : Shape
    {
        private readonly int side;

        public Square(int side)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }
    }
}

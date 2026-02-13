namespace Conclase9.Models
{
    internal class Square
    {
        private readonly int side;
        private const int Sides = 4;

        public Square(int side)
        {
            this.side = side;
        }

        public int Area()
        {
            return side * side;
        }
    }
}

namespace Conclase9.Models
{
    internal class Rectangle : Shape
    {
        public Rectangle(string name)
        {
            Name = name;
        }

        public static int Area(int x, int y)
        {
            return x * y;
        }
    }
}

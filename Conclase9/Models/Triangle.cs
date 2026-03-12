namespace Conclase9.Models
{
    internal class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Triangle(double angleBase, double height)
        {
            Base = angleBase;
            Height = height;
        }

        public Triangle(double angleBase, double side1, double side2)
        {
            Base = angleBase;
            Side1 = side1;
            Side2 = side2;
        }

        public override double Area()
        {
            var isHeron = Side1 != default && Side2 != default;
            if(isHeron)
            {
                var heronS = (Side1 + Side2 + Base) / 2;
                return Math.Sqrt(heronS * ((heronS - Side1) * (heronS - Side2) * (heronS - Base)));
            }
            else
            {
                return 0.5 * (Base + Height);
            }
        }
    }
}

namespace Conclase9.Models
{
    public abstract class Shape
    {
        public abstract double Area();

        public virtual void Describe()
        {
            Console.WriteLine("This is a shape");
        }
    }
}
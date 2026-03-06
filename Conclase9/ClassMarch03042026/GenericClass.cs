namespace Conclase9.ClassMarch03042026
{
    internal class GenericClass<T>
    {
        public int Status { get; set; }
        public T Data { get; set; } = default!;
    }

    internal class GenericClass<T, U> where U : Enum
    {
        public int Status { get; set; }
        public T Data { get; set; } = default!;
        public U Another { get; set; } = default!;
    }
}

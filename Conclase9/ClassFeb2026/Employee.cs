namespace Conclase9.ClassFeb2026
{
    internal sealed class Employee : Person
    {
        public int Id { get; set; }

        public Employee(int id, string name) : base(name)
        {
            Id = id;
        }
    }
}

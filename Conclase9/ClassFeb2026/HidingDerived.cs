namespace Conclase9.ClassFeb2026
{
    internal class HidingDerived : HidingBase
    {
        public new void Speak() => Console.WriteLine("Derived Class");
    }
}
namespace Conclase9.Interface
{
    internal interface IDatabaseRead
    {
        string GetById(int id);
        List<string> GetAll();
    }
}

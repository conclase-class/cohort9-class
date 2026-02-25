namespace Conclase9.ClassFeb232026
{
    internal interface IProjectDatabase
    {
        void Add(string name);              //C
        string Get(int id);                 //R
        List<string> GetAll();
        void Update(int id, string name);   //U
        void Remove(int id);               //D
    }
}
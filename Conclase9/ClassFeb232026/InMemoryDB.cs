
namespace Conclase9.ClassFeb232026
{
    internal class InMemoryDB : IProjectDatabase
    {
        public void Add(string name)
        {
            Console.WriteLine($"Added {name}");
        }

        public string Get(int id)
        {
            return id.ToString();
        }

        public List<string> GetAll()
        {
            return new List<string>
            {
                "Record"
            };
        }

        public void Remove(int id)
        {
            Console.WriteLine($"Removed record with Id: {id}");
        }

        public void Update(int id, string name)
        {
            Console.WriteLine($"Updated record with Id: {id}");
        }
    }
}
namespace Conclase9.ClassFeb232026
{
    internal class PostgresDB : IProjectDatabase
    {
        public void Add(string name)
        {
            Console.WriteLine($"[Postgres] Added {name}");
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
            Console.WriteLine($"[Postgres] Removed record with Id: {id}");
        }

        public void Update(int id, string name)
        {
            Console.WriteLine($"[Postgres] Updated record with Id: {id}");
        }
    }
}

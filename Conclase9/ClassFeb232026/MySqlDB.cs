namespace Conclase9.ClassFeb232026
{
    internal class MySqlDB : IProjectDatabase
    {
        public void Add(string name)
        {
            Console.WriteLine($"[MySQL] Added {name}");
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
            Console.WriteLine($"[MySQL] Removed record with Id: {id}");
        }

        public void Update(int id, string name)
        {
            Console.WriteLine($"[MySQL] Updated record with Id: {id}");
        }
    }
}

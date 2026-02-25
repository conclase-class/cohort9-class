using Conclase9.Interface;

namespace Conclase9.ClassFeb2026
{
    internal class UserService : IDatabaseRead, IDatabaseWrite
    {
        public void Add(string name)
        {
            Console.WriteLine("Added {0} to the DB", name);
        }

        public void Edit(string name)
        {
            Console.WriteLine("Changed to {0} in the DB", name);
        }

        public List<string> GetAll()
        {
            return new List<string>
            {
                "User 1", "User 2"
            };
        }

        public string GetById(int id)
        {
            return "User 1";
        }

        public void Remove(int id)
        {
            Console.WriteLine("Removed user with id {0}", id);
        }
    }
}
using Conclase9.Interface;

namespace Conclase9.ClassFeb2026
{
    internal class UserService : IDatabaseRead
    {
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
    }
}
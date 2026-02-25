using Conclase9.Interface;

namespace Conclase9.ClassFeb2026
{
    internal class ProductService : IDatabaseRead, IDatabaseWrite
    {
        public void Add(string name)
        {
            Console.WriteLine("Added product {0} to the DB", name);
        }

        public void Edit(string name)
        {
            Console.WriteLine("Changed product to {0} in the DB", name);
        }

        public List<string> GetAll()
        {
            return new List<string>
            {
                "Product 1", "Product 2"
            };
        }

        public string GetById(int id)
        {
            return "Product 1";
        }

        public void Remove(int id)
        {
            Console.WriteLine("Removed product with id {0}", id);
        }
    }
}

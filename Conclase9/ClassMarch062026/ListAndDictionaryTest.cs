using Conclase9.ClassFeb272027;

namespace Conclase9.ClassMarch062026
{
    internal class ListAndDictionaryTest
    {
        public static void Test()
        {
            var list = new List<string>();
            list.Add("Item 1");

            list.Remove("Item");
            list.Contains("A");
            list.Insert(0, "A");
            var num = list.Count;
            //list.Clear();

            var students = new Dictionary<int, string>
            {
                { 1, "Peace" }
            };

            students.Add(10, "John");

            if (!students.ContainsKey(10))
            {
                students.Add(10, "White");
            }

            students[11] = "Jane";
            students.Remove(8);

            var userMap = new Dictionary<int, User>
            {
                { 1, new User { Name = "Test" } }
            };

            if (userMap.TryGetValue(1, out var user))
            {
                Console.WriteLine(user.Name);
            }

            Console.WriteLine(students.Keys);
            var studentValues = userMap.Values;
            foreach (var value in studentValues) {

            }

            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Key}. Name: {student.Value}");
            }

            var sorted = new SortedDictionary<int, string>();
            sorted.Add(1, "Mike");
            sorted.Add(0, "Peace");
            foreach (var item in sorted)
            {
                Console.WriteLine($"Key: {item.Key}. Value: {item.Value}");
            }

            var added = students.TryAdd(4, "Doe");
            Console.WriteLine(added);

            var users = new List<User>
            {
                new User{ Name = "Test", Age = 20 },
                new User{ Name = "Test1", Age = 20 },
                new User{ Name = "Test2", Age = 22 },
                new User{ Name = "Test3", Age = 21 }
            };

            var userDict = users.GroupBy(u => u.Age)
                .ToDictionary(u => u.Key, u => u.ToList());

            var twentyYearOlds = userDict[20];
            Console.WriteLine(twentyYearOlds.Count);

            var listC = new List<int> { 1, 2, 1, 5, 3, 2, 6, 8, 3, 1, 2, 9 };
            Console.WriteLine(listC.Count);

            var hash = listC.ToHashSet();
            hash.Add(10);

            var listD = new HashSet<int> { 1, 3, 2, 30, 32 };

            hash.IntersectWith(listD);

            Console.WriteLine(hash.Count);

            var userTuple = GetUser();
            Console.WriteLine(userTuple.age);
            Console.WriteLine(userTuple.email);

            Test2();
        }

        public static (int age, string email) GetUser()
        {
            var idNameTupple = (20, "jane@email.com");

            return idNameTupple;
        }

        public static void Test2()
        {
            //queue:  FIFO
            var bankQueue = new Queue<string>();
            bankQueue.Enqueue("Peace");
            bankQueue.Enqueue("Toba");
            bankQueue.Enqueue("Jane");

            var person = bankQueue.Dequeue();
            Console.WriteLine($"{person} left the queue");

            bankQueue.Peek();
            Console.WriteLine(bankQueue.Peek());

            //stack: LIFO
            //House party: Served jollof rice, 
            var plates = new Stack<string>();
            plates.Push("Samuel Plate");
            plates.Push("Michael's Plate");
            plates.Push("Peace's Plate");

            var firstPlateToWash = plates.Pop();
            Console.WriteLine(firstPlateToWash);
            Console.WriteLine(plates.Peek());

            //Linked list
            //Connected elements via nodes
            //node1 - data, next, previous
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            var last = linkedList.Find(2);
            Console.WriteLine(last.Value);
        }
    }
}

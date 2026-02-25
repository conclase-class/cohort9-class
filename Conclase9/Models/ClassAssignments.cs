namespace Conclase9.Models
{
    public class ClassAssignments
    {
        public static List<Student> Students {  get; set; } = new List<Student>();

        public static void SolveStaudentProfileSystem()
        {
            var samuel = new Student();
            Students.Add(samuel);
            samuel.Id = Guid.NewGuid();
            samuel.Name = "Samuel";
            samuel.Age = 25;
            samuel.Course = ".NET Core";
            samuel.DisplayDetails();

            var peace = new Student();
            peace.Id = Guid.NewGuid();
            peace.Name = "Peace";
            peace.Age = 24;
            peace.Course = "Dev Ops";
            peace.DisplayDetails();

            Students.Add(peace);

            var mike = new Student();
            mike.Id = Guid.NewGuid();
            mike.Name = "Michael";
            mike.Age = 24;
            mike.Course = "DBA";
            mike.DisplayDetails();

            Students.Add(mike);
        }

        public static void SolvePhoneDetailsProblem()
        {
            var iPhone17 = new MobilePhone("Apple", "iPhone 17", 128, 50, true);
            iPhone17.DisplayDetails();
            iPhone17.IsPoweredOn = false;
            iPhone17.BatteryPercentage = 20;
            iPhone17.DisplayDetails();
            var samsumgFold = new MobilePhone("Samsumg", "Z Fold", 256, 87, false);
            samsumgFold.DisplayDetails();
            samsumgFold.IsPoweredOn = true;
            samsumgFold.BatteryPercentage = 88;
            samsumgFold.DisplayDetails();
        }

        public static void SolveBookProblem()
        {
            var thingsFallApart = new Book("Things Fall Apart", "Chinua Achebe", "33737373", false);
            var stayWithMe = new Book("Stay With Me", "Ayobami Adebayo", "43627882", true);
            var mySister = new Book("My Sister the Serial Killer", "Oyinkan Braithwaite", "77292044", false);

            var books = new List<Book>
            {
                mySister,
                thingsFallApart,
                stayWithMe
            };

            foreach (var book in books)
            {
                if (!book.IsBorrowed)
                {
                    book.Display();
                }
            }
        }
    }
}
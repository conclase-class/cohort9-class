namespace Conclase9.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public int Age { get; set; }
        public string Course { get; set; } = default!;

        public void DisplayDetails()
        {
            Console.WriteLine("Id: {0}\nName: {1}\nAge: {2}\nCourse: {3}.\n", 
                Id, Name, Age, Course);
        }

        public static Student? Get(Guid id)
        {
            return ClassAssignments.Students.Where(s => s.Id == id).FirstOrDefault();
        }

        public static Student? Get(string name)
        {
            return ClassAssignments.Students.Where(s => s.Name.ToUpper().Contains(name.ToUpper())).FirstOrDefault();
        }
    }
}
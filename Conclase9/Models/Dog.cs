namespace Conclase9.Models
{
    public class Dog // Class declaration
    { //Opening bracket of the class body

        public string Color { get; set; }

        //Fields declaration
        private string name;
        private int age;

        //Properties declaration
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name canoot be empty");
                }

                name = value;
            }
        }

        public int Age 
        { 
            get { return age; } 
            set
            {
                if(value < 0)
                {
                    throw new Exception("Age can not be less than 0");
                }

                age = value;
            }
        }

        //Constructors declaration
        public Dog()
        {
            
        }

        // Another constructor declaration
        public Dog(string name)
        {
            Name = name;
        }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Method declaration 
        public void Bark()
        {
            Console.WriteLine("{0} barking Wow-wow. Age: {1}", name ?? "Unknown dog", age);
        }
    } // CLosing bracket of the class body
}

namespace Conclase9.Models
{
    public class Car 
    {
        //Fields - variables that hold data
        //Access modifier   type    name the field
        private string brand;
        private int yearOfManufacture;

        // Constants
        private const int MinSpeed = 1;
        private const int MaxSpeed = 500;

        //Properties
        //Access modifier   type    name
        public string Brand 
        { 
            get { return brand; } 
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    Console.WriteLine("Invalid brand name.");
                }
                else
                {
                    brand = value;
                }
            }
        }
        public int YearOfManufacture 
        { 
            get { return yearOfManufacture; }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Invalid year of manufacture");
                }
                else
                {
                    yearOfManufacture = value;
                }
            } 
        }
        public string Model { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }

        //Methods - Define behaviors of a class. They can perform actions, return values and accept parameters
        public void Drive(int speed)
        {
            //the speed must be greater than min speed
            if (speed < MinSpeed)
            {
                Console.WriteLine($"Car not driving. Speed must be at least {MinSpeed} Km/hr.");
            }
            else if(speed > MaxSpeed)
            {
                Console.WriteLine($"Car not driving. Speed must be at most {MaxSpeed} Km/hr.");
            }
            else
            {
                //Start the car
                Console.WriteLine("Car starting...");
                //Engage the transmission
                Console.WriteLine("Car in drive mode...");
                //move
                Console.WriteLine($"Car is driving at {speed} Km/hr");
            }
        }

        //Action, behavior to display car details
        public void DisplayDetails()
        {
            Console.WriteLine("Brand: {0}\nModel: {1}\nTransmission: {2}\nEngine: {3} Ltrs\nYear: {4}\nColor: {5}\n", Brand, Model, Transmission, Engine, YearOfManufacture, Color);
        }
    }
}
//Brand - Honda, Toyota, Benz, BMW, Lexus, Kia, Innoson,                                                     
// Model - Accord, Camry, c230, i7, E350, Rio, Mi
// Year of Manufacture - 2001, 1920, 2026
// Transmission - Automatic, Manual
// Color - White, Black, Green, Red, Brown. Blue, Yellow
// Engine - 1.4, 3.0, 5.0, 7.0
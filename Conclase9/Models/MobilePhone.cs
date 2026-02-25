namespace Conclase9.Models
{
    internal class MobilePhone
    {
        private byte batteryPercentage;

        public string Brand { get; set; }
        public string Model { get; set; }
        public int StorageGb { get; set; }
        public byte BatteryPercentage 
        { 
            get { return batteryPercentage; }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    batteryPercentage = value;
                }
                else
                {
                    throw new Exception("Battery percentage can only be between 0 and 100");
                }
            } 
        }
        public bool IsPoweredOn { get; set; }

        public MobilePhone(string brand, string model, 
            int storageGb, 
            byte batteryPercentage, bool isOn)
        {
            Brand = brand;
            Model = model;
            StorageGb = storageGb;
            BatteryPercentage = batteryPercentage;
            IsPoweredOn = isOn;
        }

        public void DisplayDetails()
        {
            var onOrOff = IsPoweredOn ? "ON" : "OFF";
            Console.WriteLine($"{Brand} {Model} is powered {onOrOff}.\nBattery status: {batteryPercentage} %\n");
        }
    }
}
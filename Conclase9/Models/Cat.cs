namespace Conclase9.Models
{
    public class Cat : Animal
    {
        public Cat()
        {
           
        }

        public void MakeCatSleep()
        {
            Sleep();
        }

        private void MakeCatEat()
        {
            Feed();
        }
    }
}

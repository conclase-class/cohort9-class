namespace Conclase9.Models
{
    internal class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Log(string message, Exception exception)
        {
            Console.WriteLine($"{message}: {exception.Message}");
        }

        public void Log(Exception exception, string message)
        {
            Console.WriteLine($"{exception.Message}: {message}");
        }

        public void Log(object obj)
        {
            Console.WriteLine(obj?.ToString());
        }
    }
}
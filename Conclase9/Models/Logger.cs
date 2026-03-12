namespace Conclase9.Models
{
    internal class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }

        public static void Log(string message, Exception exception)
        {
            Console.WriteLine($"{message}: {exception.Message}");
        }

        public static void Log(Exception exception, string message)
        {
            Console.WriteLine($"{exception.Message}: {message}");
        }

        public static void Log(object obj)
        {
            Console.WriteLine(obj?.ToString());
        }
    }
}
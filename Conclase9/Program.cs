public class Program
{
    public static void Main(string[] args)
    {
        //Operators
        decimal balance = 1000m;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=====================ATM============================");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine($"Your balance is: {balance}");
                    break;
                case "2":
                    Console.Write("Please enter the deposit amount: ");
                    decimal deposit = decimal.Parse(Console.ReadLine()!);
                    if(deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine("Deposit successful");
                    }
                    else
                    {
                        Console.WriteLine("Invalid deposit amount");
                    }
                    break;
                case "3":
                    Console.Write("Please enter withdrawal amount: ");
                    decimal withdraw = decimal.Parse(Console.ReadLine()!);
                    if(withdraw <= 0)
                    {
                        Console.WriteLine("Invalid withdrawal amount");
                    }
                    else if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient fund");
                    }
                    else
                    {
                        balance -= withdraw;
                        Console.WriteLine("Withdrawal successful");
                    }
                    break;
                case "4":
                    Console.WriteLine("Thank you for banking with us.");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again");
                    break;
            }
        }
    }
}
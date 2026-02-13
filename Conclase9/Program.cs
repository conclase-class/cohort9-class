using Conclase9.Models;

public class Program
{
    public static void Main(string[] args)
    {
        //var square = new Square(7);
        //square.Area();

        var guid = Guid.NewGuid();
        //var area = square.Area();

        var num = 7;
        Console.WriteLine(num);
        var doubled = num.Double();
        Console.WriteLine(doubled);

        var num3 = 8;
        num3.Double();
    }

    public static bool Register(string name, string email, string password)
    {
        //is the name valid?
        if (string.IsNullOrEmpty(name))
        {
            return false;
        }
        //is the email valid?
        if (string.IsNullOrEmpty(email) || !IsAValidEmail(email))
        {
            return false;
        }
        //is the password valid and does it meet the length and strength requirement
        if(string.IsNullOrEmpty(password) || password.Length < 8)
        {
            return false;
        }
        //do we have an existing user with this email?
        //if yes, return
        var existingUser = GetUser(email);
        if(existingUser != null)
        {
            return false;
        }
        
        //if no, register
        var result = AddUser(name, email, password);
        return result;
    }

    static bool AddUser(string name, string email, string password)
    {
        return true;
    }

    static string GetUser(string email)
    {
        return email;
    }

    static bool IsAValidEmail(string email)
    {
        return true;
    }
}
using Conclase9.ClassFeb272027;
using Conclase9.ClassMarch022026;
using Conclase9.ClassMarch03042026;
using System.Text.Json;
using ETaskStatus = Conclase9.ClassMarch022026.ETaskStatus;

public class Program
{
    public static void Main(string[] args)
    {
        //Biwise operate on integers bit by bit
        // 5 = 00000000 00000000 00000000 00000101
        //10 = 00000000 00000000 00000000 00001010
        // & - AND - Both bits must be 1 to get 1
        // 5 & 10
        // 5 = 00000000 00000000 00000000 00000101
        //10 = 00000000 00000000 00000000 00001010
        //Res= 00000000 00000000 00000000 00000000
        //var bit5And10 = 5 & 10;
        //Console.WriteLine(bit5And10);

        // 5 | 10
        // 5 = 00000000 00000000 00000000 00000101
        //10 = 00000000 00000000 00000000 00001010
        //Res= 00000000 00000000 00000000 00001111
        //var bit5Or10 = 5 | 10;
        //Console.WriteLine(bit5Or10);

        //var user = new User
        //{
        //    Name = "Test",
        //    Email = "test@email.com",
        //    Status = AccountStatus.Active
        //};

        //AdvancedEnumTest.AssignPermission(user, Permission.Read | Permission.Create | Permission.Update);
        //if (user.Permission.HasFlag(Permission.Read))
        //{
        //    var response = AdvancedEnumTest.DisplayTask();
        //    Console.WriteLine(response);
        //    var task = JsonSerializer.Deserialize<UserTask>(response);
        //    Console.WriteLine($"Title: {task?.Title}\nStatus: {task?.StatusText}");
        //}
        //else
        //{
        //    Console.WriteLine("No permission to view data");
        //}

        var userResponse = TestService.GetUser("test@email.com");
        Console.WriteLine(JsonSerializer.Serialize(userResponse));

        var tasksResponse = TestService.GetTasksByStatus(ETaskStatus.Completed);
        Console.WriteLine(JsonSerializer.Serialize(tasksResponse));
    }

    static void PrintType<T>() where T : Enum
    {
        Console.WriteLine(typeof(T));
    }

    static void Print(TrafficLight light)
    {
        switch (light)
        {
            case TrafficLight.Red:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Stop!!!");
                break;
            case TrafficLight.Yellow:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Slow Down");
                break;
            case TrafficLight.Green:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Go!!!");
                break;
        }
    }

    static TrafficLight Next(TrafficLight light)
    {
        switch (light)
        {
            case TrafficLight.Red: return TrafficLight.Green;
            case TrafficLight.Green: return TrafficLight.Yellow;
            case TrafficLight.Yellow: return TrafficLight.Red;
            default: return TrafficLight.Red;
        }
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

//================================CLASS v STRUCT=================================================
//Features==========================Class=================================================================================Struct==================
//Type                              Reference type                                                       Value type
//Memory alloc.                     Heap (Garbage collector managed)                                     Stack
//Copy behavior                     Copies references (Multiple variable point to the same object)       Copies the entire value (independent copies)
//Constructor                       You can define parameterless constructors                            You cannot define a paramterless constructor (compiler provides one)
//Inheritance                       Supports inheritance                                                 Cannot inherit from other structs. It can only inherit from System.ValueType
//Interfaces                        Can implement interfaces                                             Can implement interface, but you can't override
//Nullability                       Can be null                                                          Can not be null unless Nullable<T>
//Performance                       More overhead due to heap allocation and GC                          Lightweight, faster for small immutable data
//Use cases                         Complex objects, entities with identity, large data structures       Small, immutable data for instance DateTime, Cordinates
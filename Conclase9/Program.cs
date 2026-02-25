using Conclase9.ClassFeb232026;

public class Program
{
    public static void Main(string[] args)
    {
        //var wallet = new Checkout(new WalletPayment());
        //wallet.Process(2500.56M);

        //var cash = new Checkout(new CashPayment());
        //cash.Process(4300.12M);

        //var card = new Checkout(new CardPayment());
        //card.Process(6804.89M);

        //IPayment cash1 = new CashPayment();
        //cash1.Pay(123.58M);

        IProjectDatabase database = new InMemoryDB();


        database.Add("Record 1");
        database.Update(1, "Record 2");
        database.Get(1);
        database.GetAll();
        database.Remove(1);
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
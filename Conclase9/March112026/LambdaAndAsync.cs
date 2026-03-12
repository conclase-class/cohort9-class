using Conclase9.ClassFeb272027;
using Conclase9.ClassMarch022026;
using System;
using System.Linq.Expressions;

namespace Conclase9.March112026
{
    internal class LambdaAndAsync
    {
        public delegate int ArithmeticOperations(int a, int b);
        public delegate void Printer(object str);

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static int MultiplyByTen(int num)
        {
            return num * 10;
        }

        public static void Test()
        {
            //Func - Delegate that represents a method that takes 0 to 16 parameters and returns a value
            Func<int, int, int> add = (x, y) => x + y;

            Func<int, int, int> mul = (a, b) =>
            {
                return a * b;
            };
            //Action - Delegate that represents a method that takes 0 to 16 parameters and returns nothing
            Action<object> print = obj => Console.WriteLine(obj);

            Func<int, int> square = x => x * x;
            print(square(7));

            var act = () => Console.WriteLine("Hello");

            var addition = add(2, 3);
            print(addition);
            var multiplication = mul(2, 3);
            print(multiplication);

            //Predicate - Delegate that represents a method that takes a parameter and returns a boolean
            Predicate<int> isEven = x => x % 2 == 0;
            print(isEven(3));

            //=> - Lambda operator
            //(parameters) => expression;
            //Lambda exprssions with list
            var numbers = new List<int> { 1, 2, 3, 4, 1, 3, 6, 5, 7, 8, 10 };
            var evenNumbers = numbers
                .Where(num => num % 2 == 0)
                .Select(num => num * 10)
                .ToList();

            evenNumbers.ForEach(num => print(num));
            // n => n % 2 == 0
            // return numbers where the number is even

            var users = new List<User>
            {
                new User{ Name = "Jane", Status = AccountStatus.Active, Age = 25 },
                new User{ Name = "John", Status = AccountStatus.Pending, Age = 32 }
            };

            var activeUsers = users.Where(u => u.Status == AccountStatus.Active).ToList();
            var adults = users.Where(user => user.Age >= 30).ToList();
        }
    }
}
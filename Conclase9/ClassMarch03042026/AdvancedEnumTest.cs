using Conclase9.ClassFeb272027;
using Conclase9.ClassMarch022026;
using System.Text.Json;

namespace Conclase9.ClassMarch03042026
{
    public class AdvancedEnumTest
    {
        public static string DisplayTask()
        {
            var task = new UserTask
            {
                Title = "Complete User Registration Endpoint",
                Status = ETaskStatus.Completed
            };

            return JsonSerializer.Serialize(task);
        }

        public static void AssignPermission(User user, Permission permission)
        {
            user.Permission = permission;
        }

        public static void FlagTest()
        {
            // Read = 1, Create = 2
            // Read | Create
            // 0010
            // 0100
            // 0110
            var permission = Permission.Read | Permission.Create;
            Console.WriteLine((int)permission);

            if (permission.HasFlag(Permission.Delete))
            {
                Console.WriteLine("User has permission to delete");
            }

            if (permission.HasFlag(Permission.Update))
            {
                Console.WriteLine("User has permission to delete");
            }

            if (permission.HasFlag(Permission.Read) && permission.HasFlag(Permission.Create))
            {
                Console.WriteLine("User has permission to read and create");
            }
        }
    }
}

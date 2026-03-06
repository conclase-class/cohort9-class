using Conclase9.ClassFeb272027.CustomExceptions;
using Conclase9.ClassMarch022026;
using Conclase9.Models;

namespace Conclase9.ClassFeb272027
{
    internal class ExceptionTest
    {
        private static List<User> _users = new List<User>
        {
            new User
            {
                Email = "user@email.com",
                Name = "Test",
                Status = AccountStatus.Pending
            },
            new User
            {
                Email = "active@email.com",
                Name = "Active",
                Status = AccountStatus.Active
            }
        };

        public static double Divide(int dividend, int divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch(DivideByZeroException ex)
            {
                Logger.Log(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                throw;
            }
        }

        public static void Open(string file)
        {
            FileStream fst = null;
            try
            {
                fst = File.Open(file, FileMode.Open);
            }
            catch (FileNotFoundException ex)
            {
                Logger.Log(ex, "File Not Found");
            }
            catch (UnauthorizedAccessException ex)
            {
                Logger.Log(ex, "Access Denied");
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "An error occurred");
            }
            finally
            {
                fst?.Dispose();
            }
        }

        public static User GetUser(string email)
        {
            var user = _users
                .Where(u => u.Email == email)
                .FirstOrDefault();

            if(user == null)
            {
                throw new NotFoundException("User not found");
            }

            return user;
        }
    }
}
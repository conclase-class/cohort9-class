using Conclase9.ClassFeb272027;
using Conclase9.ClassMarch022026;

namespace Conclase9.ClassMarch03042026
{
    internal class TestService
    {
        private static readonly List<User> users = new List<User>
        {
            new User
            {
                Name = "Test",
                Email = "test@email.com"
            }
        };

        private static readonly List<UserTask> userTasks = new List<UserTask>
        {
            new UserTask
            {
                Title = "Test",
                Status = ClassMarch022026.ETaskStatus.Completed
            }
        };

        public static ApiResponse<User> GetUser(string username)
        {
            var user = users.Where(u => u.Email == username).FirstOrDefault();
            if (user == null)
            {
                return ApiResponse<User>.Fail<User>("Not Found", 404);
            }

            return ApiResponse<User>.Ok(user);
        }

        public static ApiResponse<List<UserTask>> GetTasksByStatus(ETaskStatus status)
        {
            var tasks = userTasks.Where(t => t.Status == status).ToList();

            return ApiResponse<List<UserTask>>.Ok(tasks);
        }
    }
}

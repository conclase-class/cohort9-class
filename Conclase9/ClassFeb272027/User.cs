using Conclase9.ClassMarch022026;
using Conclase9.ClassMarch03042026;

namespace Conclase9.ClassFeb272027
{
    public class User
    {
        public string Email { get; set; } = default!;
        public string Name { get; set; } = default!;
        public AccountStatus Status { get; set; }
        public Permission Permission { get; set; }
    }
}

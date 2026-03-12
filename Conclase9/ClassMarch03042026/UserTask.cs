using Conclase9.ClassMarch022026;

namespace Conclase9.ClassMarch03042026
{
    internal class UserTask
    {
        public string Title { get; set; } = default!;
        public ETaskStatus Status { get; set; }
        public string StatusText => Status.GetDescription();
    }
}

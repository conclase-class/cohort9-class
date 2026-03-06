using System.ComponentModel;

namespace Conclase9.ClassMarch022026
{
    public enum ETaskStatus
    {
        [Description("Pending")]
        Pending,
        [Description("In Progress")]
        InProgress,
        [Description("Done")]
        Completed
    }
}
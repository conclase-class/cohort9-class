using System.ComponentModel;

namespace Conclase9.ClassMarch03042026
{
    public static class AttributeExtension
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field!, typeof(DescriptionAttribute))!;
            return attribute?.Description ?? value.ToString();
        }
    }
}

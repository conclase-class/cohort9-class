using System.Net;

namespace Conclase9.ClassMarch022026
{
    internal class EnumTest
    {
        public void Status()
        {
           //var badRequest = HttpStatusCode;
        }

        public static string GetMonth()
        {
            var month = Months.March;
            var monthInt = (int)month;
            return monthInt.ToString();
        }
    }
}
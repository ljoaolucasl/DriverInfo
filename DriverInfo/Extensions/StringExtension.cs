using System.Globalization;

namespace DriverInfo.ConsoleApp.Extensions
{
    public static class StringExtension
    {
        public static string OrDashIfEmpty(this string str)
        {
            return string.IsNullOrEmpty(str) ? "-" : str;
        }

        public static DateTime? ConvertWmiDateToDateTime(this string wmiDate)
        {
            if (DateTime.TryParseExact(wmiDate?.Split('.')[0], "yyyyMMddHHmmss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out DateTime result))
            {
                return result.Date;
            }

            return null;
        }
    }
}

using System.Globalization;

namespace Transact.Test
{
    public static class StringExtensions
    {
        public static bool IsNumeric(this string value, bool floatPoint = false)
        {
            return long.TryParse(value.RemoveSpaces(), NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out _);
        }

        public static string RemoveSpaces(this string value)
        {
            return IsNullOrEmpty(value) ? string.Empty : value.Replace(" ", string.Empty);
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}

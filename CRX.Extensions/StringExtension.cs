using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace CRX.Extensions
{
    public static class StringExtension
    {
        public static T ToEnum<T>(this string value, bool ignoreCase = true) where T : Enum => (T)Enum.Parse(typeof(T), value, ignoreCase);

        public static string ToTitleCase(this string value, bool replaceAllCapsWords = false)
        {
            if (replaceAllCapsWords)
                value = value.ToLower();

            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(value);
        }

        public static string ToLettersOnly(this string value)
        {
            var regex = new Regex("[^a-zA-Z]");
            return regex.Replace(value, "");
        }
    }
}

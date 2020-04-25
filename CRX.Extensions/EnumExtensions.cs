using System;

namespace CRX.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDisplay<T>(this T name, string splitValue = "_") where T : Enum => name.ToString().Replace(splitValue, " ");
    }
}

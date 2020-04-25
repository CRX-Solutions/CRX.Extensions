using System;
using System.Linq;

namespace CRX.Extensions
{
    public static class GenericExtensions
    {
        public static bool In<T>(this T source, params T[] list)
        {
            if (source == null)
                throw new ArgumentNullException($"{nameof(source)} cannot be null");

            return list.Contains(source);
        }
    }
}

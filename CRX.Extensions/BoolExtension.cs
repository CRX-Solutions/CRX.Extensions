namespace CRX.Extensions
{
    public static class BoolExtension
    {
        public static string ToYesNo(this bool value) => value ? "Yes" : "No";
    }
}

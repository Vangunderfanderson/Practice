namespace Utility
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string s)
            => s == null || s.Equals(string.Empty);

        public static bool IsEmpty(this string s)
            => s != null && s.Equals(string.Empty);
    }
}

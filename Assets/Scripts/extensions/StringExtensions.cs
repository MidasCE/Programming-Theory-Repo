namespace extensions
{
    public static class StringExtensions
    {
         public static bool IsNotNullOrEmpty(this string s)
        {
            return s is { Length: > 0 };
        }
    }
}
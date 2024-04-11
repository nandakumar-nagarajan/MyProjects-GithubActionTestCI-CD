namespace Utilities;

public static class StringLibrary
{
    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }

    public static int WordCount(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;
            
        return str.Trim().Length + 1;
    }
}
